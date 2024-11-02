using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository repository;

        public StudentService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<bool> ExistByIdAsync(string userId)
        {
            return await repository.AllAsReadOnly<Student>()
                .AnyAsync(s => s.UserId == userId);
        }

        public async Task<int> GetStudentIdAsync(string userId)
        {
            return await repository.AllAsReadOnly<Student>()
                .Where(s => s.UserId == userId)
                .Select(s => s.Id)
                .FirstOrDefaultAsync();
        }
    }
}
