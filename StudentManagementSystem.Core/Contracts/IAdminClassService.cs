using StudentManagementSystem.Core.Models.Class;
using StudentManagementSystem.Core.Models.Course;

namespace StudentManagementSystem.Core.Contracts
{
    public interface IAdminClassService
    {
        Task<int> CreateClassAsync(ClassFormViewModel model);
        Task EditClassAsync(int id, ClassFormViewModel model);
        Task DeleteClassAsync(int id);
        Task<IEnumerable<ClassServiceModel>> GetAllClassesAsync();
        Task<CourseServiceModel> GetClassByIdAsync(int id);
        Task<IEnumerable<string>> GetAllClassesNamesAsync();
    }
}
