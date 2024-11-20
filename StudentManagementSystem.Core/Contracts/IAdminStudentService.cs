using StudentManagementSystem.Core.Enumerations;
using StudentManagementSystem.Core.Models.Admin.Student;

namespace StudentManagementSystem.Core.Contracts
{
    public interface IAdminStudentService
    {
        Task<int> CreateStudentAsync(StudentFormViewModel model);
        Task EditStudentAsync(int id, StudentFormViewModel model);
        Task DeleteStudentAsync(int id);
        Task<IEnumerable<StudentServiceModel>> GetAllStudentsAsync();
        Task<StudentServiceModel> GetStudentByIdAsync(int id);
        Task<StudentQueryServiceModel> AllAsync(
            string? studentClass = null,
            string? searchTerm = null,
            StudentSorting sorting = StudentSorting.Name,
            int currentPage = 1,
            int studentsPerPage = 10);
        Task<bool>ExistAsync(int id);
        Task<StudentFormViewModel?> GetStudentFormModelByIdAsync(int id);
        Task<StudentDetailsViewModel> GetStudentDetailsModelByIdAsync(int id);
    }
}
