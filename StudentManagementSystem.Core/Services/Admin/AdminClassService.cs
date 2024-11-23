using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Core.Contracts.Admin;
using StudentManagementSystem.Core.Enumerations;
using StudentManagementSystem.Core.Models.Admin.Class;
using StudentManagementSystem.Core.Models.Admin.Course;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Core.Services.Admin
{
    public class AdminClassService : IAdminClassService
    {
        private readonly IRepository repository;

        public AdminClassService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<ClassQueryServiceModel> AllAsync(string? teacher = null, string? searchTerm = null, ClassSorting sorting = ClassSorting.Name, int currentPage = 1, int classesPerPage = 10)
        {
            var classQuery = repository.AllAsReadOnly<Class>().Where(s => s.IsDeleted == false);

            if (!string.IsNullOrWhiteSpace(teacher))
            {
                string[] teacherNameArr = teacher.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                classQuery = classQuery
                    .Where(s => s.Teacher.Titles == teacherNameArr[0] &&
                    s.Teacher.FirstName == teacherNameArr[1] &&
                    s.Teacher.LastName == teacherNameArr[2] &&
                    s.IsDeleted == false
                );
            }

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                classQuery = classQuery
                    .Where(t => t.Name.ToLower().Contains(searchTerm.ToLower()) ||
                                t.Teacher.FirstName.ToLower().Contains(searchTerm.ToLower()) ||
                                t.Teacher.LastName.ToLower().Contains(searchTerm.ToLower()));
            }

            classQuery = sorting switch
            {
                ClassSorting.Name => classQuery.OrderBy(t => t.Name),
                ClassSorting.Teacher => classQuery.OrderBy(t => t.Teacher.FirstName).ThenBy(t => t.Teacher.LastName),
                ClassSorting.StudentsCount => classQuery.OrderByDescending(t => t.Students.Count),
                _ => classQuery.OrderBy(s => s.Name)
            };

            var classes = await classQuery
                .Skip((currentPage - 1) * classesPerPage)
                .Take(classesPerPage)
                .Select(s => new ClassServiceModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    Teacher = s.Teacher.Titles + " " + s.Teacher.FirstName + " " + s.Teacher.LastName,
                    StudentsCount = s.Students.Count(st => st.IsDeleted == false)
                })
                .ToListAsync();

            var totalClassesCount = await classQuery.CountAsync();

            return new ClassQueryServiceModel
            {
                TotalClassesCount = totalClassesCount,
                Classes = classes
            };
        }

        public Task<bool> ClassExistAsync(int id)
        {
            return repository.AllAsReadOnly<Class>().AnyAsync(c => c.Id == id && c.IsDeleted == false);
        }

        public async Task<int> CreateClassAsync(ClassFormViewModel model)
        {
            var entity = new Class
            {
                Name = model.Name,
                TeacherId = model.TeacherId,
                ClassCourses = model.SelectedCourseIds
                    .Select(courseId => new ClassCourse
                    {
                        CourseId = courseId,
                        EnrollmentDate = DateTime.UtcNow
                    })
                    .ToList()
            };

            await repository.AddAsync(entity);
            await repository.SaveChangesAsync();

            return entity.Id;
        }

        public async Task DeleteClassAsync(int id)
        {
            var selectedClass = await repository.GetByIdAsync<Class>(id);

            if (selectedClass != null && selectedClass.IsDeleted == false)
            {
                selectedClass.IsDeleted = true;
            }

            await repository.SaveChangesAsync();
        }

        public async Task EditClassAsync(int id, ClassFormViewModel model)
        {
            var entity = await repository.GetByIdAsync<Class>(id);

            if (entity != null && entity.IsDeleted == false)
            {
                entity.Name = model.Name;
                entity.TeacherId = model.TeacherId;

                var selectedCourseIds = model.SelectedCourseIds.ToHashSet();
                var existingCourseIds = entity.ClassCourses.Select(cc => cc.CourseId).ToHashSet();
                var coursesToAdd = selectedCourseIds.Except(existingCourseIds);
                var coursesToRemove = existingCourseIds.Except(selectedCourseIds);

                foreach (var courseId in coursesToAdd)
                {
                    entity.ClassCourses.Add(new ClassCourse
                    {
                        CourseId = courseId,
                        EnrollmentDate = DateTime.UtcNow
                    });
                }

                foreach (var courseId in coursesToRemove)
                {
                    var courseToRemove = entity.ClassCourses.FirstOrDefault(cc => cc.CourseId == courseId);
                    if (courseToRemove != null)
                    {
                        entity.ClassCourses.Remove(courseToRemove);
                    }
                }

                await repository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<ClassServiceModel>> GetAllClassesAsync()
        {
            var classes = await repository.AllAsReadOnly<Class>()
                .Where(c => c.IsDeleted == false)
                .Select(c => new ClassServiceModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();

            classes = SortClassNames(classes.Select(c => c.Name))
                .Select(name => classes.First(c => c.Name == name))
                .ToList();

            return classes;
        }

        public async Task<IEnumerable<string>> GetAllClassesNamesAsync()
        {
            var classes = await repository
                .AllAsReadOnly<Class>()
                .Where(c => !c.IsDeleted)
                .Select(c => c.Name)
                .ToListAsync();

            classes = SortClassNames(classes).ToList();

            return classes;
        }

        public Task<CourseServiceModel> GetClassByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ClassDetailsViewModel> GetClassDetailsModelByIdAsync(int id)
        {
            var classDetails = await repository.AllAsReadOnly<Class>()
                .Where(c => c.Id == id && c.IsDeleted == false)
                .Select(c => new ClassDetailsViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Teacher = c.Teacher.Titles + " " + c.Teacher.FirstName + " " + c.Teacher.LastName,
                    Students = c.Students
                        .Where(s => s.IsDeleted == false)
                        .Select(s => s.FirstName + " " + s.LastName)
                        .ToList()
                })
                .FirstOrDefaultAsync();

            if (classDetails == null)
            {
                throw new InvalidOperationException("Class not found.");
            }

            return classDetails;
        }

        public async Task<ClassFormViewModel> GetClassFormModelByIdAsync(int id)
        {
            var selectedClass = await repository.AllAsReadOnly<Class>()
                .Where(s => s.Id == id && s.IsDeleted == false)
                .Select(s => new ClassFormViewModel
                {
                    Name = s.Name,
                    TeacherId = s.TeacherId,
                    SelectedCourseIds = s.ClassCourses.Select(cc => cc.CourseId).ToList()
                })
                .FirstOrDefaultAsync();

            if (selectedClass == null)
            {
                throw new ArgumentException($"Class not found.");
            }

            return selectedClass;
        }

        public IEnumerable<string> SortClassNames(IEnumerable<string> classNames)
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
