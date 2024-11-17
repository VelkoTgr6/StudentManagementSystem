using StudentManagementSystem.Core.Models.Class;
using StudentManagementSystem.Core.Models.Course;
using StudentManagementSystem.Core.Models.Student;
using StudentManagementSystem.Core.Models.Teacher;

namespace StudentManagementSystem.Core.Contracts
{
    public interface IAdminService
    {
        Task<int> CreateStudentAsync(StudentFormViewModel model);
        Task EditStudentAsync<T>(int id, StudentFormViewModel model);
        Task<int> CreateCourseAsync(CourseFormViewModel model, string publisherId);
        Task EditCourseAsync<T>(int id, CourseFormViewModel model, string publisherId);
        Task<int> CreateTeacherAsync(TeacherFormViewModel model);
        Task EditTeacherAsync<T>(int id, TeacherFormViewModel model);
        Task DeleteAsync<T>();
        Task<IEnumerable<T>> GetAllAsync<T>() where T : class;
        Task<T> GetByIdAsync<T>() where T : class;
        Task<bool> StudentEmailExistAsync(string email);
        Task<IEnumerable<ClassServiceModel>> AllClassesAsync();
    }
}
