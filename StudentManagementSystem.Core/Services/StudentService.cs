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
            return await repository.AllAsReadOnly<Student>()
                .AnyAsync(s => s.UserId == userId);
        }

        public async Task<IEnumerable<StudentAbsencesViewModel>> GetAllAbsencesAsync(int studentId)
        {
            var excusedAbsences = await repository.AllAsReadOnly<Absence>()
                .Where(a => a.StudentId == studentId && a.IsDeleted)
                .CountAsync();

            var absences =await repository.AllAsReadOnly<Absence>()
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
            var studentClassId = await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == studentId)
                .Select(s => s.ClassId)
                .FirstOrDefaultAsync();

            var courses = await repository.AllAsReadOnly<Course>()
                .Where(c => c.CourseClasses.Any(cc => cc.ClassId == studentClassId))
                .ToListAsync();

            var student = await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == studentId)
                .Select(s => new
                {
                    s.FirstName,
                    s.LastName
                })
                .FirstOrDefaultAsync();

            var grades = await repository.AllAsReadOnly<Grade>()
                .Where(g => g.StudentId == studentId)
                .Include(g => g.Course)
                .ToListAsync();

            var courseGrades = courses.Select(course => new StudentGradesViewModel
            {
                CourseName = course.Name,
                Grades = grades
                    .Where(grade => grade.CourseId == course.Id)
                    .Select(g=> new GradeServiceModel()
                    {
                        GradeScore = g.GradeScore.ToString(),
                        GradeType = g.GradeType,
                    })
                    .ToList(),
                AverageGrade = grades.Average(g => g.GradeScore).ToString(),
                StudentName = student.FirstName + " " + student.LastName
            }).ToList();

            

            return courseGrades;
        }

        public async Task<IEnumerable<StudentNewsViewModel>> GetAllNewsForStudentAsync(int studentId)
        {
            var teacherId = await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == studentId)
                .Include(s=>s.Class)
                .Include(s => s.Class.Teacher)
                .Select(s=>s.Class.Teacher.UserId)
                .FirstOrDefaultAsync();

            var teacherName = await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == studentId)
                .Include(s => s.Class)
                .Include(s => s.Class.Teacher)
                .Select(s => $"{s.Class.Teacher.Titles} {s.Class.Teacher.FirstName} {s.Class.Teacher.LastName}")
                .FirstOrDefaultAsync();


            var news = await repository.AllAsReadOnly<News>()
                .Where(n => n.PublisherId == teacherId)
                .OrderByDescending(n => n.Date)
                .Select(n => new StudentNewsViewModel
                {
                    Title = n.Title,
                    Content = n.Content,
                    CreatedAt = n.Date.ToString("dd/MM/yyyy"),
                    CreatedBy = teacherName
                })
                .ToListAsync();

            return news;
        }

        public async Task<IEnumerable<StudentRemarksViewModel>> GetAllRemarksAsync(int studentId)
        {
            var remarks =await repository.AllAsReadOnly<Remark>()
                .Where(r => r.StudentId == studentId)
                .Select(r => new StudentRemarksViewModel
                {
                    Content = r.RemarkText,
                    Date = r.Date.ToString("dd/MM/yyyy"),
                    TeacherName =r.Teacher.Titles + " " + r.Teacher.FirstName + " " + r.Teacher.LastName,
                    CourseName = r.Course.Name
                })
                .ToListAsync();

            return remarks;
        }

        public async Task<int> GetStudentIdAsync(string userId)
        {
            return await repository.AllAsReadOnly<Student>()
                .Where(s => s.UserId == userId)
                .Select(s => s.Id)
                .FirstOrDefaultAsync();
        }
    }
}
