using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Infrastructure.Data.Common
{
    public interface IRepository
    {
        IQueryable<T> All<T>() where T : class;
        IQueryable<T> AllAsReadOnly<T>() where T : class;
        Task AddAsync<T>(T entity) where T : class;
        Task<int> SaveChangesAsync();
        void DeleteStudent(Student entity);
        void DeleteTeacher(Teacher entity);
        void DeleteCourse(Course entity);
        Task<T?> GetByIdAsync<T>(object id) where T : class;
        Task<bool> StudentEmailExistAsync(string email);
        Task<string> GetIdByEmailAsync(string email);
    }
}
