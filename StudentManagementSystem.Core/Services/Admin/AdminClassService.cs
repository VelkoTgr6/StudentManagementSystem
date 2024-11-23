using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Core.Contracts.Admin;
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

        public Task DeleteClassAsync(int id)
        {
            throw new NotImplementedException();
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

                //var existingCourseIds = entity.StudentCourses.Select(sc => sc.CourseId).ToList();
                //var newCourseIds = model.SelectedCourseIds.Except(existingCourseIds).ToList();
                //var removedCourseIds = existingCourseIds.Except(model.SelectedCourseIds).ToList();

                //foreach (var courseId in newCourseIds)
                //{
                //    entity.StudentCourses.Add(new ClassCourse
                //    {
                //        CourseId = courseId,
                //        EnrollmentDate = DateTime.UtcNow
                //    });
                //}

                //// Remove courses no longer selected
                //var coursesToRemove = entity.StudentCourses
                //    .Where(sc => removedCourseIds.Contains(sc.CourseId))
                //    .ToList();

                //foreach (var course in coursesToRemove)
                //{
                //    entity.StudentCourses.Remove(course);
                //}
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
