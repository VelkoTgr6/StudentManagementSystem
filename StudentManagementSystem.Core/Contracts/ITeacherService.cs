using StudentManagementSystem.Core.Models.Teacher;

namespace StudentManagementSystem.Core.Contracts
{
    public interface ITeacherService
    {
        Task<IEnumerable<StudentsViewModel>> GetStudentsByTeacherAndClassAsync(int classId, string userId);
        Task<TeacherClassesViewModel> GetAllClassesByTeacher(string userId);
        Task<TeacherStudentDetailsViewModel> GetStudentDetailsAsync(int studentId);
        Task<int> AddGradeToStudent(GradeFormModel model,int studentId);
        Task<IEnumerable<TeacherCourseServiceModel>> GetTeacherCourses(string teacherId);
    }
}
