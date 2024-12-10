using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StudentManagementSystem.Core.Contracts.Admin;
using StudentManagementSystem.Core.Enumerations;
using StudentManagementSystem.Core.Models.Admin.Student;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Core.Services.Admin
{
    public class AdminStudentService : IAdminStudentService
    {
        private readonly IRepository repository;

        public AdminStudentService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<StudentQueryServiceModel> AllAsync(string? studentClass = null, string? searchTerm = null, StudentSorting sorting = StudentSorting.Name, int currentPage = 1, int studentsPerPage = 10)
        {
            var studentsQuery = repository.AllAsReadOnly<Student>().Where(s => s.IsDeleted == false);

            if (!string.IsNullOrWhiteSpace(studentClass))
            {
                studentsQuery = studentsQuery.Where(s => s.Class.Name == studentClass && s.IsDeleted == false);
            }

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                studentsQuery = studentsQuery
                    .Where(s => s.FirstName.ToLower().Contains(searchTerm) ||
                            s.MiddleName.ToLower().Contains(searchTerm) ||
                            s.LastName.ToLower().Contains(searchTerm) ||
                            s.ContactDetails.Contains(searchTerm) ||
                            s.Email.ToLower().Contains(searchTerm) ||
                            s.Class.Name.ToLower().Contains(searchTerm));
            }

            studentsQuery = sorting switch
            {
                StudentSorting.Name => studentsQuery.OrderBy(s => s.FirstName).ThenBy(s => s.LastName),
                StudentSorting.Email => studentsQuery.OrderBy(s => s.Email),
                StudentSorting.Class => studentsQuery.OrderBy(s => s.Class.Name),
                StudentSorting.Grade => studentsQuery.OrderByDescending(s => s.Performance),
                _ => studentsQuery.OrderBy(s => s.FirstName).ThenBy(s => s.LastName)
            };

            var students = await studentsQuery
                .Skip((currentPage - 1) * studentsPerPage)
                .Take(studentsPerPage)
                .Select(s => new StudentServiceModel
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    MiddleName = s.MiddleName,
                    SchoolName = s.School.Name,
                    LastName = s.LastName,
                    ContactDetails = s.ContactDetails,
                    Email = s.Email,
                    PersonalId = s.PersonalId,
                    DateOfBirth = s.DateOfBirth,
                    Class = s.Class.Name,
                    Performance = s.Performance.ToString("f2"),
                })
                .ToListAsync();

            var totalStudentsCount = await studentsQuery.CountAsync();

            return new StudentQueryServiceModel
            {
                TotalStudentsCount = totalStudentsCount,
                Students = students
            };
        }



        public async Task<int> CreateStudentAsync(StudentFormViewModel model, IFormFile? profilePictureFile)
        {
            var userId = await repository.GetIdByEmailAsync(model.Email);

            string profilePicturePath = "/images/profiles/default.jpg";

            if (profilePictureFile != null)
            {
                profilePicturePath = await SaveProfilePictureAsync(profilePictureFile);
            }

            var entity = new Student
            {
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                ContactDetails = model.ContactDetails,
                Email = model.Email,
                PersonalId = model.PersonalId,
                DateOfBirth = model.DateOfBirth,
                UserId = userId,
                ClassId = model.ClassId,
                ProfilePicturePath = profilePicturePath,
                SchoolId = 1
            };

            await repository.AddAsync(entity);
            await repository.SaveChangesAsync();

            return entity.Id;
        }


        public async Task DeleteStudentAsync(int id)
        {
            var student = await repository.GetByIdAsync<Student>(id);

            if (student != null && student.IsDeleted == false)
            {
                student.IsDeleted = true;
                var identityUser = await repository.GetIdentityUserByIdAsync(student.UserId);

                if (identityUser != null)
                {
                    identityUser.UserName = null;
                    identityUser.Email = null;
                    identityUser.PhoneNumber = null;
                    identityUser.EmailConfirmed = false;
                    identityUser.PhoneNumberConfirmed = false;
                    identityUser.LockoutEnabled = true;
                    identityUser.NormalizedEmail = null;
                    identityUser.NormalizedUserName = null;
                    identityUser.PasswordHash = null;
                }
            }

            await repository.SaveChangesAsync();
        }

        public async Task EditStudentAsync(int id, StudentFormViewModel model, IFormFile? profilePictureFile)
        {
            var entity = await repository.GetByIdAsync<Student>(id);

            if (entity != null && entity.IsDeleted == false)
            {
                entity.FirstName = model.FirstName;
                entity.MiddleName = model.MiddleName;
                entity.LastName = model.LastName;
                entity.ContactDetails = model.ContactDetails;
                entity.Email = model.Email;
                entity.PersonalId = model.PersonalId;
                entity.DateOfBirth = model.DateOfBirth;
                entity.ClassId = model.ClassId;

                if (profilePictureFile != null)
                {
                    entity.ProfilePicturePath = await SaveProfilePictureAsync(profilePictureFile);
                }
                else if (string.IsNullOrWhiteSpace(entity.ProfilePicturePath))
                {
                    entity.ProfilePicturePath = "/images/profiles/default.jpg"; 
                }
            }

            await repository.SaveChangesAsync();
        }
        private async Task<string> SaveProfilePictureAsync(IFormFile file)
        {
            // Set the path where the file will be saved
            var uploads = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "profiles");
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName); // Unique file name
            var filePath = Path.Combine(uploads, fileName);

            // Ensure the directory exists
            if (!Directory.Exists(uploads))
            {
                Directory.CreateDirectory(uploads);
            }

            // Save the file
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return "/images/profiles/" + fileName; // Return the relative path
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await repository.AllAsReadOnly<Student>().AnyAsync(s => s.Id == id && s.IsDeleted == false);
        }

        public async Task<IEnumerable<StudentServiceModel>> GetAllStudentsAsync()
        {
            return await repository.AllAsReadOnly<StudentServiceModel>().ToListAsync();
        }

        public async Task<IEnumerable<string>> GetAllStudentsNamesAsync()
        {
            return await repository
                .AllAsReadOnly<Student>()
                .Select(s => s.FirstName + " " + s.LastName)
                .ToListAsync();
        }

        public async Task<StudentServiceModel> GetStudentByIdAsync(int id)
        {
            var student = await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == id && s.IsDeleted == false)
                .Select(s => new StudentServiceModel
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    MiddleName = s.MiddleName,
                    LastName = s.LastName,
                    SchoolName = s.School.Name,
                    ContactDetails = s.ContactDetails,
                    Email = s.Email,
                    PersonalId = s.PersonalId,
                    DateOfBirth = s.DateOfBirth,
                    Class = s.Class.Name,
                    Performance = s.Performance.ToString("f2"),
                })
                .FirstOrDefaultAsync();

            if (student == null)
            {
                throw new ArgumentException($"Student not found.");
            }

            return student;
        }

        public async Task<StudentDetailsViewModel> GetStudentDetailsModelByIdAsync(int id)
        {
            var student = await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == id && s.IsDeleted == false)
                .Select(s => new StudentDetailsViewModel()
                {
                    Id = s.Id,
                    ProfilePicturePath = s.ProfilePicturePath,
                    PersonalId = s.PersonalId,
                    SchoolName = s.School.Name,
                    FirstName = s.FirstName,
                    MiddleName = s.MiddleName,
                    LastName = s.LastName,
                    Class = s.Class.Name,
                    Email = s.Email,
                    DateOfBirth = s.DateOfBirth,
                    ContactDetails = s.ContactDetails,
                    Performance = s.Performance.ToString("f2"),
                    Grades = s.Grades
                })
                .FirstOrDefaultAsync();

            if (student == null)
            {
                throw new ArgumentException($"Student not found.");
            }

            return student;
        }

        public async Task<StudentFormViewModel?> GetStudentFormModelByIdAsync(int id)
        {
            var student = await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == id && s.IsDeleted == false)
                .Select(s => new StudentFormViewModel
                {
                    FirstName = s.FirstName,
                    MiddleName = s.MiddleName,
                    LastName = s.LastName,
                    ContactDetails = s.ContactDetails,
                    Email = s.Email,
                    PersonalId = s.PersonalId,
                    DateOfBirth = s.DateOfBirth,
                    ClassId = s.ClassId,
                    ProfilePicturePath = s.ProfilePicturePath
                })
                .FirstOrDefaultAsync();

            if (student == null)
            {
                throw new ArgumentException($"Student not found.");
            }

            return student;
        }

        public async Task<IEnumerable<StudentGradeServiceViewModel>> GetStudentGradesAsync(int studentId)
        {
            var studentGrades = await repository.AllAsReadOnly<Grade>()
                .Where(g => g.StudentId == studentId && g.IsDeleted == false)
                .Select(g => new StudentGradeServiceViewModel
                {
                    Id = g.Id,
                    DateAdded = g.GradeAssignedDate,
                    ClassName = g.Student.Class.Name,
                    Grade = g.GradeScore.ToString(),
                    GradeType = g.GradeType.ToString(),
                    Name = g.Course.Name
                })
                .OrderByDescending(g => g.Name)
                .ToListAsync();

            return studentGrades;
        }

        public async Task EditGradeAsync(int gradeId, StudentGradeFormViewModel model)
        {
            var grade = await repository.All<Grade>()
                .FirstOrDefaultAsync(g => g.Id == gradeId && !g.IsDeleted);

            if (grade == null)
            {
                throw new ArgumentException("Grade not found.");
            }

            grade.GradeScore = model.GradeScore;
            grade.GradeType = model.GradeType;
            grade.CourseId = model.CourseId;


            await repository.UpdateStudentsPerformanceAllAsync();

            await repository.SaveChangesAsync();
        }

        public async Task<StudentGradeFormViewModel> GetGradeFormModelByIdAsync(int gradeId)
        {
            var grade =await repository.AllAsReadOnly<Grade>()
                .Where(g => g.Id == gradeId && g.IsDeleted == false)
                .Select(g => new StudentGradeFormViewModel
                {
                    GradeId = g.Id,
                    StudentId = g.StudentId,
                    GradeScore = g.GradeScore,
                    GradeType = g.GradeType,
                    CourseId = g.CourseId
                })
                .FirstOrDefaultAsync();

            if (grade == null)
            {
                throw new ArgumentException($"Grade not found.");
            }

            return grade;
        }

        public async Task DeleteGradeAsync(int id)
        {
            var grade =await repository.All<Grade>()
                .FirstOrDefaultAsync(g => g.Id == id && !g.IsDeleted);

            if (grade == null)
            {
                throw new ArgumentException("Grade not found.");
            }

            grade.IsDeleted = true;

            await repository.UpdateStudentsPerformanceAllAsync();

            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<StudentRemarksServiceModel>> GetStudentRemarksAsync(int studentId)
        {
            var remarks = await repository.AllAsReadOnly<Remark>()
                .Where(r => r.StudentId == studentId && r.IsDeleted == false)
                .Select(r=> new StudentRemarksServiceModel()
                {
                    RemarkId = r.Id,
                    CourseId = r.CourseId,
                    CourseName = r.Course.Name,
                    RemarkText = r.RemarkText
                })
                .OrderBy(r => r.CourseName)
                .ToListAsync();

            return remarks;
        }

        public async Task EditRemarkAsync(int remarkId, StudentRemarkFormViewModel model)
        {
            var remark =await repository.All<Remark>()
                .FirstOrDefaultAsync(r => r.Id == remarkId && r.IsDeleted == false);

            remark.RemarkText = model.RemarkText;
            remark.CourseId = model.CourseId;

            await repository.SaveChangesAsync();
        }

        public async Task<StudentRemarkFormViewModel> GetRemarkFormModelByIdAsync(int id)
        {
            var remark = await repository.AllAsReadOnly<Remark>()
                .Where(r => r.Id == id && r.IsDeleted == false)
                .Select(r => new StudentRemarkFormViewModel
                {
                    Id = r.Id,
                    StudentId = r.StudentId,
                    CourseId = r.CourseId,
                    RemarkText = r.RemarkText
                })
                .FirstOrDefaultAsync();

            if (remark == null)
            {
                throw new ArgumentException($"Remark not found.");
            }

            return remark;
        }

        public async Task DeleteRemarkAsync(int id)
        {
            var remark =await repository.All<Remark>().FirstOrDefaultAsync(r => r.Id == id);

            if (remark == null || remark.IsDeleted == true)
            {
                throw new ArgumentException("Remark not found.");
            }

            remark.IsDeleted = true;

            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<StudentAbsenceServiceModel>> GetStudentAbsencesAsync(int studentId)
        {
            var absences = await repository.AllAsReadOnly<Absence>()
                .Where(a => a.StudentId == studentId && a.IsDeleted == false)
                .Select(a => new StudentAbsenceServiceModel
                {
                    Id = a.Id,
                    CourseName = a.Course.Name,
                    AbsenceDate = a.Date.ToString("dd.MM.yyyy"),
                })
                .OrderBy(a => a.CourseName)
                .ToListAsync();

            return absences;
        }

        public async Task<StudentAbsenceFormViewModel> GetAbsenceFormModelByIdAsync(int id)
        {
            var absence =await repository.AllAsReadOnly<Absence>()
                .Where(a => a.Id == id && a.IsDeleted == false)
                .Select(a => new StudentAbsenceFormViewModel
                {
                    Id = a.Id,
                    StudentId = a.StudentId,
                    CourseId = a.CourseId,
                    AbsenceDate = a.Date
                })
                .FirstOrDefaultAsync();

            if (absence == null)
            {
                throw new ArgumentException($"Absence not found.");
            }

            return absence;
        }

        public async Task EditAbsenceAsync(int id, StudentAbsenceFormViewModel model)
        {
            var absence =await repository.All<Absence>().FirstOrDefaultAsync(a => a.Id == id);

            if (absence == null || absence.IsDeleted == true)
            {
                throw new ArgumentException("Absence not found.");
            }

            absence.Date = model.AbsenceDate;
            absence.CourseId = model.CourseId;

             await repository.SaveChangesAsync();
        }

        public async Task DeleteAbsenceAsync(int id)
        {
            var absence =await repository.All<Absence>().FirstOrDefaultAsync(a => a.Id == id);

            if (absence == null || absence.IsDeleted == true)
            {
                throw new ArgumentException("Absence not found.");
            }

            absence.IsDeleted = true;

            await repository.SaveChangesAsync();
        }
    }
}
