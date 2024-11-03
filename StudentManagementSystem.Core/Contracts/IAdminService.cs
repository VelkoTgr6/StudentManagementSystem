using StudentManagementSystem.Core.Models.Student;

namespace StudentManagementSystem.Core.Contracts
{
    public interface IAdminService
    {
        Task CreateAsync(StudentFormViewModel model);
        Task<T> EditAsync<T>() where T : class;
        Task<T> DeleteAsync<T>() where T : class;
        Task<IEnumerable<T>> GetAllAsync<T>() where T : class;
        Task<T> UpdateAsync<T>() where T : class;
    }
}
