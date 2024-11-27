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

        public async Task<int> AddGradeToStudent(GradeFormModel model,int studentId)
        {
            var student = await repository.All<Student>()
                .Where(s => s.Id == studentId)
                .Include(s => s.Grades)
                .FirstOrDefaultAsync();

            if (student == null)
            {
                throw new ArgumentNullException(nameof(student), "Student not found");
            }

            var grade = new Grade
            {
                StudentId = studentId,
                CourseId = model.CourseId,
                GradeScore = model.GradeScore,
                GradeType = model.GradeType,
                GradeAssignedDate = DateTime.UtcNow
            };

            student.Grades.Add(grade);

            await repository.SaveChangesAsync();

            return grade.Id;
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
                .Select(cc => new TeacherClassServiceViewModel 
                {
                    ClassName = cc.Class.Name,
                    Id = cc.ClassId
                })
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

        public async Task<TeacherStudentDetailsViewModel> GetStudentDetailsAsync(int studentId)
        {
            var student = await repository.AllAsReadOnly<Student>()
                .Include(s => s.Class)
                .Include(s => s.Grades)
                    .ThenInclude(g => g.Course)
                .Where(s => s.Id == studentId)
                .Select(s => new TeacherStudentDetailsViewModel
                {
                    StudentId = s.Id,
                    StudentName = $"{s.FirstName} {s.MiddleName} {s.LastName}",
                    ClassName = s.Class.Name,
                    ClassId = s.ClassId,
                    Grades = s.Grades
                        .Select(g => new GradeServiceViewModel
                        {
                            Id = g.Id,
                            GradeScore = g.GradeScore.ToString("f2"),
                            CourseName = g.Course.Name,
                            GradeType = g.GradeType
                        })
                        .OrderBy(g => g.CourseName)
                        .ToList()
                })
                .FirstOrDefaultAsync();

            if (student == null)
            {
                throw new ArgumentNullException(nameof(student), "Student not found");
            }

            return student;
        }

        public async Task<IEnumerable<StudentsViewModel>> GetStudentsByTeacherAndClassAsync(int classId, string userId)
        {
            var teacher = await repository.AllAsReadOnly<Teacher>()
                .FirstOrDefaultAsync(t => t.UserId == userId);

            if (teacher == null)
            {
                throw new ArgumentNullException(nameof(teacher));
            }

            var students = await repository.All<Student>()
                .Where(s => s.ClassId == classId)
                .OrderBy(s => s.FirstName)
                .Select(s => new StudentsViewModel
                {
                    Id = s.Id,
                    Name = $"{s.FirstName} {s.MiddleName} {s.LastName}",
                    ClassName = s.Class.Name
                })
                .ToListAsync();

            return students;
        }
        private List<TeacherClassServiceViewModel> SortClassNames(IEnumerable<TeacherClassServiceViewModel> classNames)
        {
            return classNames
                .Select(name => new
                {
                    Original = name,
                    NumberPart = int.Parse(new string(name.ClassName.TakeWhile(char.IsDigit).ToArray())),
                    TextPart = new string(name.ClassName.SkipWhile(char.IsDigit).ToArray())
                })
                .OrderBy(x => x.NumberPart)
                .ThenBy(x => x.TextPart)
                .Select(x => x.Original)
                .ToList();
        }

        public async Task<IEnumerable<TeacherCourseServiceModel>> GetTeacherCourses (string teacherId)
        {
            var teacher = await repository.AllAsReadOnly<Teacher>()
                .Include(t => t.Courses)
                .FirstOrDefaultAsync(t => t.UserId == teacherId);

            var teacherCourses = teacher?.Courses
                .Select(t => new TeacherCourseServiceModel
                {
                    Id = t.Id,
                    Name = t.Name
                })
                .ToList();

            if (teacherCourses == null)
            {
                throw new ArgumentNullException(nameof(teacherCourses), "Teacher has no courses");
            }

            return teacherCourses;
        }
    }
}
