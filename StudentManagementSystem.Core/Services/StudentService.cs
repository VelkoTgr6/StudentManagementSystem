using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Core.Models.Student;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository repository;

        public StudentService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<bool> ExistByIdAsync(string userId)
        {
            ValidateString(userId, nameof(userId));

            return await repository.AllAsReadOnly<Student>()
                .AnyAsync(s => s.UserId == userId);
        }

        public async Task<IEnumerable<StudentAbsencesViewModel>> GetAllAbsencesAsync(int studentId)
        {
            ValidateId(studentId, nameof(studentId));
            await EnsureStudentExistsAsync(studentId);

            var excusedAbsences = await repository.AllAsReadOnly<Absence>()
                .Where(a => a.StudentId == studentId && a.IsDeleted)
                .CountAsync();

            var absences = await repository.AllAsReadOnly<Absence>()
                .Where(a => a.StudentId == studentId)
                .Select(a => new StudentAbsencesViewModel
                {
                    Date = a.Date.ToString("dd/MM/yyyy"),
                    CourseName = a.Course.Name,
                    ExcusedAbsences = excusedAbsences
                })
                .ToListAsync();

            return absences;
        }

        public async Task<IEnumerable<StudentGradesViewModel>> GetAllGradesAsync(int studentId)
        {
            ValidateId(studentId, nameof(studentId));
            await EnsureStudentExistsAsync(studentId);

            var studentClassId = await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == studentId && !s.IsDeleted)
                .Select(s => s.ClassId)
                .FirstOrDefaultAsync();

            var courses = await repository.AllAsReadOnly<Course>()
                .Where(c => c.CourseClasses.Any(cc => cc.ClassId == studentClassId))
                .ToListAsync();

            var student = await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == studentId && !s.IsDeleted)
                .Select(s => new
                {
                    s.FirstName,
                    s.LastName
                })
                .FirstOrDefaultAsync();

            if (student == null)
            {
                throw new KeyNotFoundException($"Student with id {studentId} was not found.");
            }

            var grades = await repository.AllAsReadOnly<Grade>()
                .Where(g => g.StudentId == studentId)
                .Include(g => g.Course)
                .ToListAsync();

            if (!grades.Any())
            {
                return new List<StudentGradesViewModel>();
            }

            var courseGrades = courses.Select(course => new StudentGradesViewModel
            {
                CourseName = course.Name,
                Grades = grades
                    .Where(grade => grade.CourseId == course.Id)
                    .Select(g => new GradeServiceModel()
                    {
                        GradeScore = g.GradeScore.ToString(),
                        GradeType = g.GradeType,
                    })
                    .ToList(),
                // Keep existing behavior: overall average repeated per course
                AverageGrade = grades.Average(g => g.GradeScore).ToString("f2"),
                StudentName = student.FirstName + " " + student.LastName
            }).ToList();

            return courseGrades;
        }

        public async Task<IEnumerable<StudentNewsViewModel>> GetAllNewsForStudentAsync(int studentId)
        {
            ValidateId(studentId, nameof(studentId));
            await EnsureStudentExistsAsync(studentId);

            var teacherName = await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == studentId && !s.IsDeleted)
                .Include(s => s.Class)
                .Include(s => s.Class.Teacher)
                .Select(s => $"{s.Class.Teacher.Titles} {s.Class.Teacher.FirstName} {s.Class.Teacher.LastName}")
                .FirstOrDefaultAsync();

            var studentName = await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == studentId && !s.IsDeleted)
                .Select(s => $"{s.FirstName} {s.MiddleName} {s.LastName}")
                .FirstOrDefaultAsync();

            if (string.IsNullOrWhiteSpace(teacherName) || string.IsNullOrWhiteSpace(studentName))
            {
                // If key names are missing, there is nothing to filter or display meaningfully
                return new List<StudentNewsViewModel>();
            }

            var news = await repository.AllAsReadOnly<News>()
                .Where(n => !n.IsDeleted)
                .OrderByDescending(n => n.Date)
                .ToListAsync();

            var newsList = new List<StudentNewsViewModel>();

            foreach (var n in news)
            {
                switch (n.Title)
                {
                    case "New Grade!":
                        if (n.Content?.Contains(studentName, StringComparison.OrdinalIgnoreCase) == true)
                        {
                            var newNews = new StudentNewsViewModel
                            {
                                Id = n.Id,
                                Title = n.Title,
                                Content = n.Content,
                                CreatedAt = n.Date.ToString("dd/MM/yyyy"),
                                CreatedBy = teacherName
                            };
                            newsList.Add(newNews);
                        }
                        break;
                    case "New Remark!":
                        if (n.Content?.Contains(studentName, StringComparison.OrdinalIgnoreCase) == true)
                        {
                            var newNews = new StudentNewsViewModel
                            {
                                Id = n.Id,
                                Title = n.Title,
                                Content = n.Content,
                                CreatedAt = n.Date.ToString("dd/MM/yyyy"),
                                CreatedBy = teacherName
                            };
                            newsList.Add(newNews);
                        }
                        break;
                    case "New Absence!":
                        if (n.Content?.Contains(studentName, StringComparison.OrdinalIgnoreCase) == true)
                        {
                            var newNews = new StudentNewsViewModel
                            {
                                Id = n.Id,
                                Title = n.Title,
                                Content = n.Content,
                                CreatedAt = n.Date.ToString("dd/MM/yyyy"),
                                CreatedBy = teacherName
                            };
                            newsList.Add(newNews);
                        }
                        break;
                    default:
                        var defNews = new StudentNewsViewModel
                        {
                            Id = n.Id,
                            Title = n.Title,
                            Content = n.Content,
                            CreatedAt = n.Date.ToString("dd/MM/yyyy"),
                            CreatedBy = teacherName
                        };
                        newsList.Add(defNews);

                        break;

                }
            }

            return newsList;
        }

        public async Task<IEnumerable<StudentRemarksViewModel>> GetAllRemarksAsync(int studentId)
        {
            ValidateId(studentId, nameof(studentId));
            await EnsureStudentExistsAsync(studentId);

            var remarks = await repository.AllAsReadOnly<Remark>()
                .Where(r => r.StudentId == studentId && r.IsDeleted == false)
                .Select(r => new StudentRemarksViewModel
                {
                    Content = r.RemarkText,
                    Date = r.Date.ToString("dd/MM/yyyy"),
                    TeacherName = r.Teacher.Titles + " " + r.Teacher.FirstName + " " + r.Teacher.LastName,
                    CourseName = r.Course.Name
                })
                .ToListAsync();

            return remarks;
        }

        public async Task<StudentHomePageViewModel> GetHomePageAsync(int studentId)
        {
            ValidateId(studentId, nameof(studentId));
            await EnsureStudentExistsAsync(studentId);

            var student = await repository.AllAsReadOnly<Student>()
                .Include(s => s.Аbsences)
                .Include(s => s.Class)
                .Where(s => s.Id == studentId && !s.IsDeleted)
                .Select(s => new StudentHomePageViewModel
                {
                    Name = s.FirstName + " " + s.LastName,
                    SchoolName = s.School.Name,
                    ClassName = s.Class.Name,
                    ClassTeacher = s.Class.Teacher.Titles + " " + s.Class.Teacher.FirstName + " " + s.Class.Teacher.LastName,
                    AbsencesCount = s.Аbsences.Count().ToString(),
                    AverageGrade = (s.Grades.Any()
                        ? s.Grades.Average(g => g.GradeScore)
                        : 0.0).ToString("f2"),
                    GradesCount = s.Grades.Count().ToString(),
                    Remarks = s.Remarks.Count().ToString(),
                })
                .FirstOrDefaultAsync();

            if (student == null)
            {
                throw new KeyNotFoundException($"Student with id {studentId} was not found.");
            }

            return student;
        }

        public async Task<IEnumerable<StudentScheduleViewModel>> GetScheduleAsync(int studentId)
        {
            ValidateId(studentId, nameof(studentId));
            await EnsureStudentExistsAsync(studentId);

            var classId = await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == studentId && !s.IsDeleted)
                .Select(s => s.ClassId)
                .FirstOrDefaultAsync();

            // If the student has no class assigned, return empty schedule
            if (classId == 0)
            {
                return new List<StudentScheduleViewModel>();
            }

            var schedule = await repository.AllAsReadOnly<CourseSchedule>()
                .Include(s => s.Course)
                .Where(s => s.ClassId == classId)
                .Select(s => new StudentScheduleViewModel
                {
                    CourseName = s.Course.Name,
                    StartTime = s.StartTime.ToString(),
                    EndTime = s.EndTime.ToString(),
                    Day = s.Day.ToString(),
                    TeacherName = s.Course.Teacher.Titles + " " + s.Course.Teacher.FirstName + " " + s.Course.Teacher.LastName
                })
                .ToListAsync();

            return schedule;
        }

        public async Task<StudentProfileViewModel> GetStudentDetailsAsync(int studentId)
        {
            ValidateId(studentId, nameof(studentId));
            await EnsureStudentExistsAsync(studentId);

            var student = await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == studentId && !s.IsDeleted)
                .Select(s => new StudentProfileViewModel
                {
                    FirstName = s.FirstName,
                    MiddleName = s.MiddleName,
                    LastName = s.LastName,
                    BirthDate = s.DateOfBirth.ToString("dd/MM/yyyy"),
                    PersonalIdentificationNumber = s.PersonalId,
                    SchoolName = s.School.Name,
                    ClassName = s.Class.Name,
                    Email = s.Email,
                    ContactDetails = s.ContactDetails,
                    ProfilePicturePath = s.ProfilePicturePath,
                    ClassTeacher = s.Class.Teacher.Titles + " " + s.Class.Teacher.FirstName + " " + s.Class.Teacher.LastName
                })
                .FirstOrDefaultAsync();

            if (student == null)
            {
                throw new KeyNotFoundException($"Student with id {studentId} was not found.");
            }

            return student;
        }

        public async Task<int> GetStudentIdAsync(string userId)
        {
            ValidateString(userId, nameof(userId));

            var id = await repository.AllAsReadOnly<Student>()
                .Where(s => s.UserId == userId)
                .Select(s => s.Id)
                .FirstOrDefaultAsync();

            if (id == 0)
            {
                throw new KeyNotFoundException($"Student id for user '{userId}' was not found.");
            }

            return id;
        }

        private static void ValidateId(int id, string paramName)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(paramName, $"Parameter '{paramName}' must be a positive integer.");
            }
        }

        private static void ValidateString(string value, string paramName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"Parameter '{paramName}' cannot be null or empty.", paramName);
            }
        }

        private async Task EnsureStudentExistsAsync(int studentId)
        {
            var exists = await repository.AllAsReadOnly<Student>()
                .AnyAsync(s => s.Id == studentId && !s.IsDeleted);

            if (!exists)
            {
                throw new KeyNotFoundException($"Student with id {studentId} was not found or is deleted.");
            }
        }
    }
}
