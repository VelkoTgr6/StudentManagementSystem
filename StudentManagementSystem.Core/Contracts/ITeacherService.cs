using StudentManagementSystem.Core.Models.Teacher;

namespace StudentManagementSystem.Core.Contracts
{
    public interface ITeacherService
    {
        Task<IEnumerable<StudentsViewModel>> GetStudentsByTeacherAndClassAsync(int classId, string userId);
        Task<TeacherClassesViewModel> GetAllClassesByTeacher(string userId);
    }
}
