using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Core.Models.Class;
using StudentManagementSystem.Core.Models.Course;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Core.Services
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

            if (entity != null)
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
            return await repository.AllAsReadOnly<Class>()
                .Select(c => new ClassServiceModel
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToListAsync();
        }

        public async Task<IEnumerable<string>> GetAllClassesNamesAsync()
        {
            return await repository.AllAsReadOnly<Class>()
                .Select(c => c.Name)
                .ToListAsync();
        }

        public Task<CourseServiceModel> GetClassByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
