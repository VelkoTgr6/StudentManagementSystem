using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Core.Models.Admin.Class;
using StudentManagementSystem.Core.Models.Admin.Course;
using StudentManagementSystem.Core.Models.Admin.Student;
using StudentManagementSystem.Core.Models.Admin.Teacher;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Core.Services
{
    public class AdminService : IAdminService
    {
        private readonly IRepository repository;

        public AdminService(IRepository _repository)
        {
            repository = _repository;
        }
     

        public async Task DeleteAsync<T>()
        {
            switch (typeof(T).Name)
            {
                case "Student":
                    repository.DeleteStudent(new Student());
                    break;
                case "Teacher":
                    repository.DeleteTeacher(new Teacher());
                    break;
                case "Course":
                    repository.DeleteCourse(new Course());
                    break;
                default:
                    throw new InvalidOperationException($"Unsupported type: {typeof(T).Name}");
            }

            await repository.SaveChangesAsync();
            
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>() where T : class
        {
            var students = await repository.All<T>().ToListAsync();

            return students;
        }

        public Task<T> GetByIdAsync<T>() where T : class
        {
            return repository.AllAsReadOnly<T>().FirstAsync();
        }

        public async Task<string> GetUserIdByEmail(string email)
        {
            return await repository.GetIdByEmailAsync(email);
        }

        public async Task<bool> EmailExistAsync(string email)
        {
            return await repository.EmailExistAsync(email);
        }
    }
}
