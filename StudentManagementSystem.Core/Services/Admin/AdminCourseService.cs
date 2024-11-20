using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Core.Contracts.Admin;
using StudentManagementSystem.Core.Models.Admin.Course;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Core.Services.Admin
{
    public class AdminCourseService : IAdminCourseService
    {
        private readonly IRepository repository;

        public AdminCourseService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<bool> CourseExistAsync(int id)
        {
            return await repository.AllAsReadOnly<Course>()
                .Where(c=>c.IsDeleted == false)
                .AnyAsync(c => c.Id == id);
        }

        public async Task<int> CreateCourseAsync(CourseFormViewModel model, string publisherId)
        {
            var entity = new Course
            {
                Name = model.Name,
                Description = model.Description,
                TeacherId = model.TeacherId,
                PublisherId = publisherId
            };

            await repository.AddAsync(entity);
            await repository.SaveChangesAsync();

            return entity.Id;
        }

        public Task DeleteCourseAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task EditCourseAsync(int id, CourseFormViewModel model, string publisherId)
        {
            var course = await repository.GetByIdAsync<Course>(id);

            if (course != null && course.IsDeleted == false)
            {
                course.Name = model.Name;
                course.Description = model.Description;
                course.TeacherId = model.TeacherId;
                course.PublisherId = publisherId;
            }

            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<CourseServiceModel>> GetAllCoursesAsync()
        {
            return await repository.AllAsReadOnly<Course>()
                .Where(c => c.IsDeleted == false)
               .Select(c => new CourseServiceModel
               {
                   Id = c.Id,
                   Name = c.Name
               })
               .ToListAsync();
        }

        public async Task<IEnumerable<string>> GetAllCoursesNamesAsync()
        {
            return await repository.AllAsReadOnly<Course>()
                .Where(c => c.IsDeleted == false)
                .Select(c => c.Name)
                .ToListAsync();
        }

        public Task<CourseServiceModel> GetCourseByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
