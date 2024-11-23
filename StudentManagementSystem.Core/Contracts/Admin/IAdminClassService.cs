using StudentManagementSystem.Core.Enumerations;
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
        Task<ClassQueryServiceModel> AllAsync(
            string? teacher = null,
            string? searchTerm = null,
            ClassSorting sorting = ClassSorting.Name,
            int currentPage = 1,
            int classesPerPage = 10);
        Task<bool> ClassExistAsync(int id);
        Task<ClassDetailsViewModel> GetClassDetailsModelByIdAsync(int id);
        Task<ClassFormViewModel> GetClassFormModelByIdAsync(int id);
    }
}
