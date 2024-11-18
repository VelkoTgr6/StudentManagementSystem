using StudentManagementSystem.Core.Models.Teacher;

namespace StudentManagementSystem.Core.Contracts
{
    public interface IAdminTeacherService
    {
        Task<int> CreateTeacherAsync(TeacherFormViewModel model);
        Task EditTeacherAsync(int id, TeacherFormViewModel model);
        Task DeleteTeacherAsync(int id);
        Task<IEnumerable<TeacherServiceModel>> GetAllTeachersAsync();
        Task<TeacherServiceModel> GetTeacherByIdAsync(int id);
    }
}
