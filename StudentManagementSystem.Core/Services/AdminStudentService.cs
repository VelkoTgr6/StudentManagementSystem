using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Core.Models.Student;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Core.Services
{
    public class AdminStudentService : IAdminStudentService
    {
        private readonly IRepository repository;

        public AdminStudentService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<int> CreateStudentAsync(StudentFormViewModel model)
        {
            var userId = await repository.GetIdByEmailAsync(model.Email);

            var entity = new Student
            {
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                ContactDetails = model.ContactDetails,
                Email = model.Email,
                PersonalId = model.PersonalId,
                DateOfBirth = model.DateOfBirth,
                UserId = userId,
                ClassId = model.ClassId
            };

            await repository.AddAsync(entity);
            await repository.SaveChangesAsync();

            return entity.Id;
        }

        public Task DeleteStudentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task EditStudentAsync(int id, StudentFormViewModel model)
        {
            var entity = await repository.GetByIdAsync<Student>(id);

            if (entity != null)
            {
                entity.FirstName = model.FirstName;
                entity.MiddleName = model.MiddleName;
                entity.LastName = model.LastName;
                entity.ContactDetails = model.ContactDetails;
                entity.Email = model.Email;
                entity.PersonalId = model.PersonalId;
                entity.DateOfBirth = model.DateOfBirth;
                entity.ClassId = model.ClassId;
            }

            await repository.SaveChangesAsync();
        }

        public Task<IEnumerable<StudentServiceModel>> GetAllStudentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<StudentServiceModel> GetStudentByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
