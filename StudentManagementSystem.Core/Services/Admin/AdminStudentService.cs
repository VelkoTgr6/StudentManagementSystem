using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
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
                    LastName = s.LastName,
                    ContactDetails = s.ContactDetails,
                    Email = s.Email,
                    PersonalId = s.PersonalId,
                    DateOfBirth = s.DateOfBirth,
                    Class = s.Class.Name
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
                ProfilePicturePath = profilePicturePath
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
                    ContactDetails = s.ContactDetails,
                    Email = s.Email,
                    PersonalId = s.PersonalId,
                    DateOfBirth = s.DateOfBirth,
                    Class = s.Class.Name,
                    Performance = s.Performance
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
                    FirstName = s.FirstName,
                    MiddleName = s.MiddleName,
                    LastName = s.LastName,
                    Class = s.Class.Name,
                    Email = s.Email,
                    DateOfBirth = s.DateOfBirth,
                    ContactDetails = s.ContactDetails,
                    Performance = s.Performance.ToString(),
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
    }
}
