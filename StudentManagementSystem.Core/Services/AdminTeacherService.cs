using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Core.Models.Teacher;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Core.Services
{
    public class AdminTeacherService : IAdminTeacherService
    {
        private readonly IRepository repository;

        public AdminTeacherService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<int> CreateTeacherAsync(TeacherFormViewModel model)
        {
            var userId = await repository.GetIdByEmailAsync(model.Email);

            var entity = new Teacher
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                ContactDetails = model.ContactDetails,
                Titles = model.Titles,
                Email = model.Email,
                UserId = userId
            };

            await repository.AddAsync(entity);
            await repository.SaveChangesAsync();

            return entity.Id;
        }

        public Task DeleteTeacherAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task EditTeacherAsync(int id, TeacherFormViewModel model)
        {
            var teacher = await repository.GetByIdAsync<Teacher>(id);

            if (teacher != null)
            {
                teacher.FirstName = model.FirstName;
                teacher.LastName = model.LastName;
                teacher.ContactDetails = model.ContactDetails;
                teacher.Titles = model.Titles;
                teacher.Email = model.Email;
            }

            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<TeacherServiceModel>> GetAllTeachersAsync()
        {
            return await repository.AllAsReadOnly<Teacher>()
               .Select(t => new TeacherServiceModel
               {
                   Id = t.Id,
                   Name = $"{t.Titles} {t.FirstName} {t.LastName}"
               })
               .ToListAsync();
        }

        public Task<TeacherServiceModel> GetTeacherByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
