using StudentManagementSystem.Core.Models.Admin.Class;
using StudentManagementSystem.Core.Models.Admin.Course;
using StudentManagementSystem.Core.Models.Admin.Student;
using StudentManagementSystem.Core.Models.Admin.Teacher;

namespace StudentManagementSystem.Core.Contracts.Admin
{
    public interface IAdminService
    {
        //Task<int> CreateStudentAsync(StudentFormViewModel model);
        //Task EditStudentAsync<T>(int id, StudentFormViewModel model);
        //Task<int> CreateCourseAsync(CourseFormViewModel model, string publisherId);
        //Task EditCourseAsync<T>(int id, CourseFormViewModel model, string publisherId);
        //Task<int> CreateTeacherAsync(TeacherFormViewModel model);
        //Task EditTeacherAsync<T>(int id, TeacherFormViewModel model);
        Task DeleteAsync<T>();
        Task<IEnumerable<T>> GetAllAsync<T>() where T : class;
        Task<T> GetByIdAsync<T>() where T : class;
        Task<bool> EmailExistAsync(string email);
        //Task<IEnumerable<ClassServiceModel>> AllClassesAsync();
        //Task<IEnumerable<TeacherServiceModel>> AllTeachersAsync();
        //Task<bool> CourseExistAsync(int id);
        //Task<IEnumerable<CourseServiceModel>> AllCoursesAsync();
        //Task<int> CreateClassAsync(ClassFormViewModel model);
        //Task EditClassAsync<T>(int id, ClassFormViewModel model);
    }
}
