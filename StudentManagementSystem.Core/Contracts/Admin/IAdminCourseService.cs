using StudentManagementSystem.Core.Models.Admin.Course;

namespace StudentManagementSystem.Core.Contracts.Admin
{
    public interface IAdminCourseService
    {
        Task<int> CreateCourseAsync(CourseFormViewModel model, string publisherId);
        Task EditCourseAsync(int id, CourseFormViewModel model, string publisherId);
        Task DeleteCourseAsync(int id);
        Task<IEnumerable<CourseServiceModel>> GetAllCoursesAsync();
        Task<CourseServiceModel> GetCourseByIdAsync(int id);
        Task<bool> CourseExistAsync(int id);
        Task<IEnumerable<string>> GetAllCoursesNamesAsync();
    }
}
