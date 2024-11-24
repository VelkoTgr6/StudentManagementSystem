using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Core.Models.Teacher;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Core.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IRepository repository;

        public TeacherService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<TeacherClassesViewModel> GetAllClassesByTeacher(string userId)
        {
            var teacher = await repository.AllAsReadOnly<Teacher>()
                .Include(t => t.Courses)
                .FirstOrDefaultAsync(t => t.UserId == userId);

            if (teacher == null)
            {
                throw new ArgumentNullException(nameof(teacher));
            }

            var teacherCourseIds = teacher.Courses
                .Select(t => t.Id)
                .ToList();

            var classCourses = await repository
                .AllAsReadOnly<ClassCourse>()
                .Where(cc => teacherCourseIds.Contains(cc.CourseId))
                .Select(cc => cc.Class.Name)
                .Distinct()
                .ToListAsync();

            var sortedClassNames = SortClassNames(classCourses);

            var model = new TeacherClassesViewModel
            {
                TeacherName = $"{teacher.Titles} {teacher.FirstName} {teacher.LastName}",
                Classes = sortedClassNames,
                ClassSearchTerm = string.Empty
            };

            return model;
        }

        public async Task<IEnumerable<StudentsViewModel>> GetStudentsByTeacherAndClassAsync(int classId, string userId)
        {
            var teacher = await repository.AllAsReadOnly<Teacher>()
                .FirstOrDefaultAsync(t => t.UserId == userId);

            if (teacher == null)
            {
                throw new ArgumentNullException(nameof(teacher));
            }

            var teacherCourseIds = teacher.Courses
                .Select(t => t.Id)
                .ToList();

            var classCourseExists = await repository
                .AllAsReadOnly<ClassCourse>()
                .AnyAsync(cc => cc.ClassId == classId && teacherCourseIds.Contains(cc.CourseId));

            var students = await repository.All<Student>()
                .Where(s => s.ClassId == classId)
                .Select(s => new StudentsViewModel
                {
                    Name = $"{s.FirstName} {s.MiddleName} {s.LastName}",
                    ClassName = s.Class.Name
                })
                .OrderBy(s => s.Name)
                .ToListAsync();

            return students;
        }
        private IEnumerable<string> SortClassNames(IEnumerable<string> classNames)
        {
            return classNames
                .Select(name => new
                {
                    Original = name,
                    NumberPart = int.Parse(new string(name.TakeWhile(char.IsDigit).ToArray())),
                    TextPart = new string(name.SkipWhile(char.IsDigit).ToArray())
                })
                .OrderBy(x => x.NumberPart)
                .ThenBy(x => x.TextPart)
                .Select(x => x.Original)
                .ToList();
        }
    }
}
