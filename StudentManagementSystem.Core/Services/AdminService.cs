using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Core.Models.Student;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;
using System.Security.Claims;

namespace StudentManagementSystem.Core.Services
{
    public class AdminService : IAdminService
    {
        private readonly IRepository repository;

        public AdminService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task CreateAsync(StudentFormViewModel model)
        { 

            var entity = new Student
            {
                Id = model.Id,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                ContactDetails = model.ContactDetails,
                Email = model.Email,
                PersonalId = model.PersonalId,
                DateOfBirth = model.DateOfBirth,
            };

            await repository.AddAsync(entity);
            await repository.SaveChangesAsync();
        }

        public Task<T> DeleteAsync<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public Task<T> EditAsync<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>() where T : class
        {
            var students = await repository.All<T>().ToListAsync();

            return students;
        }

        public Task<T> UpdateAsync<T>() where T : class
        {
            throw new NotImplementedException();
        }
    }
}
