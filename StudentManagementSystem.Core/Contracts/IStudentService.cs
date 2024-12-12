using StudentManagementSystem.Core.Models.Student;

namespace StudentManagementSystem.Core.Contracts
{
    public interface IStudentService
    {
        Task<bool> ExistByIdAsync(string userId);
        Task<int> GetStudentIdAsync(string userId);
        Task<IEnumerable<StudentNewsViewModel>> GetAllNewsForStudentAsync(int studentId);
        Task<IEnumerable<StudentGradesViewModel>> GetAllGradesAsync(int studentId);
        Task<IEnumerable<StudentRemarksViewModel>> GetAllRemarksAsync(int studentId);
        Task<IEnumerable<StudentAbsencesViewModel>> GetAllAbsencesAsync(int studentId);
        Task<IEnumerable<StudentScheduleViewModel>> GetScheduleAsync(int studentId);
        Task<StudentHomePageViewModel> GetHomePageAsync(int studentId);
        Task<StudentProfileViewModel> GetStudentDetailsAsync(int studentId);
    }
}
