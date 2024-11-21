using StudentManagementSystem.Core.Models.Admin.Class;
using StudentManagementSystem.Core.Models.Admin.Course;

namespace StudentManagementSystem.Core.Contracts.Admin
{
    public interface IAdminClassService
    {
        Task<int> CreateClassAsync(ClassFormViewModel model);
        Task EditClassAsync(int id, ClassFormViewModel model);
        Task DeleteClassAsync(int id);
        Task<IEnumerable<ClassServiceModel>> GetAllClassesAsync();
        Task<CourseServiceModel> GetClassByIdAsync(int id);
        Task<IEnumerable<string>> GetAllClassesNamesAsync();
        public IEnumerable<string> SortClassNames(IEnumerable<string> classNames);
    }
}
