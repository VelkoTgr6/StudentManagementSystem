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

        public async Task<int> AddGradeToStudent(GradeFormModel model, int studentId)
        {
            var student = await repository.All<Student>()
                .Where(s => s.Id == studentId && !s.IsDeleted)
                .Include(s => s.Grades)
                .FirstOrDefaultAsync();

            if (student == null)
            {
                throw new ArgumentNullException(nameof(student), "Student not found");
            }

            var course = await repository.All<Course>()
                .Where(c => c.Id == model.CourseId && !c.IsDeleted)
                .FirstOrDefaultAsync();

            if (course == null)
            {
                throw new ArgumentNullException(nameof(course), "Course not found");
            }

            if (model.CustomGradeType == null)
            {
                var grade = new Grade
                {
                    StudentId = studentId,
                    CourseId = model.CourseId,
                    GradeScore = model.GradeScore,
                    GradeType = $"{model.GradeType}",
                    GradeAssignedDate = DateTime.UtcNow
                };

                student.Grades.Add(grade);

                await repository.UpdateStudentsPerformanceAllAsync();

                await repository.SaveChangesAsync();

                return grade.Id;
            }

            var customGrade = new Grade
            {
                StudentId = studentId,
                CourseId = model.CourseId,
                GradeScore = model.GradeScore,
                GradeType = $"{model.GradeType} ({model.CustomGradeType})",
                GradeAssignedDate = DateTime.UtcNow
            };


            student.Grades.Add(customGrade);

            await repository.UpdateStudentsPerformanceAllAsync();

            await repository.SaveChangesAsync();

            return customGrade.Id;

        }

        public async Task<TeacherClassesViewModel> GetAllClassesByTeacher(string userId)
        {
            var teacher = await repository.AllAsReadOnly<Teacher>()
                .Include(t => t.Courses.Where(c => !c.IsDeleted))
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
                .Where(cc => teacherCourseIds.Contains(cc.CourseId) && !cc.Class.IsDeleted)
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
                .Where(s => s.Id == studentId && !s.IsDeleted)
                .Include(s => s.Class)
                .Include(s => s.Grades.Where(g => !g.Course.IsDeleted && !g.IsDeleted))
                .Include(s => s.Аbsences.Where(a => !a.IsDeleted))
                .Include(s => s.Remarks.Where(r => !r.IsDeleted))
                .Select(s => new TeacherStudentDetailsViewModel
                {
                    StudentId = s.Id,
                    StudentName = $"{s.FirstName} {s.MiddleName} {s.LastName}",
                    ClassName = s.Class.Name,
                    ClassId = s.ClassId,
                    Grades = s.Grades
                        .Where(g => !g.IsDeleted)
                        .Select(g => new GradeServiceViewModel
                        {
                            Id = g.Id,
                            GradeScore = g.GradeScore.ToString("f2"),
                            CourseName = g.Course.Name,
                            GradeType = g.GradeType
                        })
                        .OrderBy(g => g.CourseName)
                        .ToList(),
                    Absences = s.Аbsences
                        .Where(a => !a.IsDeleted)
                        .Select(a => new AbsenceServiceViewModel
                        {
                            Id = a.Id,
                            CourseName = a.Course.Name,
                            Date = a.Date.ToString("dd/MM/yyyy")
                        })
                        .OrderBy(a => a.CourseName)
                        .ToList(),
                    Remarks = s.Remarks
                        .Where(r => !r.IsDeleted)
                        .Select(r => new RemarkServiceViewModel
                        {
                            Id = r.Id,
                            CourseName = r.Course.Name,
                            RemarkText = r.RemarkText
                        })
                        .OrderBy(r => r.CourseName)
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
                .Where(s => s.ClassId == classId && !s.IsDeleted)
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

        public async Task<IEnumerable<TeacherCourseServiceModel>> GetTeacherCourses(string teacherId)
        {
            var teacher = await repository.AllAsReadOnly<Teacher>()
                .Include(t => t.Courses.Where(c => !c.IsDeleted))
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

        public async Task<int> AddAbsenceToStudentAsync(AbsenceFormViewModel model, int studentId)
        {
            var student = await repository.All<Student>()
                .Where(s => s.Id == studentId && !s.IsDeleted)
                .Include(s => s.Аbsences.Where(a => !a.IsDeleted))
                .Include(s => s.Class)
                .Include(s => s.Class.ClassCourses)
                .FirstOrDefaultAsync();

            if (student == null)
            {
                throw new ArgumentNullException(nameof(student), "Student not found");
            }

            var course = await repository.All<Course>()
                .Where(c => c.Id == model.CourseId && !c.IsDeleted)
                .FirstOrDefaultAsync();

            if (course == null)
            {
                throw new ArgumentNullException(nameof(course), "Course not found");
            }

            var absence = new Absence
            {
                StudentId = studentId,
                CourseId = model.CourseId,
                Date = model.AbsenceDate
            };

            student.Аbsences.Add(absence);

            await repository.SaveChangesAsync();

            return absence.Id;
        }

        public async Task<int> AddRemarkToStudentAsync(RemarkFormViewModel model, int studentId)
        {
            var student = await repository.All<Student>()
                .Where(s => s.Id == studentId && !s.IsDeleted)
                .Include(s => s.Remarks.Where(r => !r.IsDeleted))
                .Include(s => s.Class)
                .Include(s => s.Class.ClassCourses)
                .FirstOrDefaultAsync();

            if (student == null)
            {
                throw new ArgumentNullException(nameof(student), "Student not found");
            }

            var course = await repository.All<Course>()
                .Where(c => c.Id == model.CourseId && !c.IsDeleted)
                .FirstOrDefaultAsync();

            if (course == null)
            {
                throw new ArgumentNullException(nameof(course), "Course not found");
            }

            var remark = new Remark
            {
                StudentId = studentId,
                TeacherId = model.TeacherId,
                CourseId = model.CourseId,
                RemarkText = model.RemarkText
            };

            student.Remarks.Add(remark);

            await repository.SaveChangesAsync();

            return remark.Id;
        }

        public async Task<int> GetTeacherEntityIdByUserIdAsync(string userId)
        {
            var teacher = await repository.AllAsReadOnly<Teacher>()
                .FirstOrDefaultAsync(t => t.UserId == userId && !t.IsDeleted);

            if (teacher == null)
            {
                throw new ArgumentNullException(nameof(teacher), "Teacher not found");
            }

            return teacher.Id;
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

        public async Task<bool> RemarkOfStudentExists(int studentId, string remarkText, int courseId)
        {
            var student = await repository.All<Student>()
                .Where(s => s.Id == studentId && !s.IsDeleted)
                .Include(s => s.Remarks.Where(r => !r.IsDeleted))
                .Include(s => s.Class)
                .Include(s => s.Class.ClassCourses)
                .FirstOrDefaultAsync();

            if (student == null)
            {
                throw new ArgumentNullException(nameof(student), "Student not found");
            }

            if (student.Remarks == null)
            {
                return false;
            }

            var remarkExists = student.Remarks
                .Any(r => r.RemarkText.ToLower() == remarkText.ToLower() &&
                          r.CourseId == courseId);

            return remarkExists;
        }

        public async Task<string> GetCourseNameById(int courseId)
        {
            var courseName = await repository.AllAsReadOnly<Course>()
                .Where(c => c.Id == courseId && !c.IsDeleted)
                .Select(c => c.Name)
                .FirstOrDefaultAsync();

            if (courseName == null)
            {
                throw new ArgumentNullException(nameof(courseName), "Course not found");
            }

            return courseName;
        }
    }
}
