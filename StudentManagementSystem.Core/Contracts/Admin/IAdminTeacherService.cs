using StudentManagementSystem.Core.Enumerations;
using StudentManagementSystem.Core.Models.Admin.Teacher;

namespace StudentManagementSystem.Core.Contracts.Admin
{
    public interface IAdminTeacherService
    {
        Task<int> CreateTeacherAsync(TeacherFormViewModel model);
        Task EditTeacherAsync(int id, TeacherFormViewModel model);
        Task DeleteTeacherAsync(int id);
        Task<IEnumerable<TeacherServiceModel>> GetAllTeachersAsync();
        Task<TeacherServiceModel> GetTeacherByIdAsync(int id);
        Task<TeacherQueryServiceModel> AllAsync(string? course = null,
            string? searchTerm = null,
            TeacherSorting sorting = TeacherSorting.Name,
            int currentPage = 1,
            int teachersPerPage = 10);
        Task<bool>ExistAsync(int id);
        Task<TeacherDetailsViewModel> GetTeacherDetailsModelByIdAsync(int id);
        Task<TeacherFormViewModel> GetTeacherFormModelByIdAsync(int id);
        Task<IEnumerable<string>> GetAllTeachersNamesAsync();
    }
}
