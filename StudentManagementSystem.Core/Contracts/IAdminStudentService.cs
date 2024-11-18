using StudentManagementSystem.Core.Models.Student;

namespace StudentManagementSystem.Core.Contracts
{
    public interface IAdminStudentService
    {
        Task<int> CreateStudentAsync(StudentFormViewModel model);
        Task EditStudentAsync(int id, StudentFormViewModel model);
        Task DeleteStudentAsync(int id);
        Task<IEnumerable<StudentServiceModel>> GetAllStudentsAsync();
        Task<StudentServiceModel> GetStudentByIdAsync(int id);
    }
}
