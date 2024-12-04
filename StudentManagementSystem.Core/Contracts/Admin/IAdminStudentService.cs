using Microsoft.AspNetCore.Http;
using StudentManagementSystem.Core.Enumerations;
using StudentManagementSystem.Core.Models.Admin.Student;

namespace StudentManagementSystem.Core.Contracts.Admin
{
    public interface IAdminStudentService
    {
        Task<int> CreateStudentAsync(StudentFormViewModel model, IFormFile? profilePictureFile);
        Task EditStudentAsync(int id, StudentFormViewModel model, IFormFile? profilePictureFile);
        Task DeleteStudentAsync(int id);
        Task<IEnumerable<StudentServiceModel>> GetAllStudentsAsync();
        Task<StudentServiceModel> GetStudentByIdAsync(int id);
        Task<StudentQueryServiceModel> AllAsync(
            string? studentClass = null,
            string? searchTerm = null,
            StudentSorting sorting = StudentSorting.Name,
            int currentPage = 1,
            int studentsPerPage = 10);
        Task<bool> ExistAsync(int id);
        Task<StudentFormViewModel?> GetStudentFormModelByIdAsync(int id);
        Task<StudentDetailsViewModel> GetStudentDetailsModelByIdAsync(int id);
        Task<IEnumerable<string>> GetAllStudentsNamesAsync();
        Task<IEnumerable<StudentGradeServiceViewModel>> GetStudentGradesAsync(int studentId);
        Task EditGradeAsync(int gradeId, StudentGradeFormViewModel model);
        Task<StudentGradeFormViewModel> GetGradeFormModelByIdAsync(int gradeId);
        Task DeleteGradeAsync(int id);
        Task<IEnumerable<StudentRemarksServiceModel>> GetStudentRemarksAsync(int studentId);
        Task EditRemarkAsync(int studentId, StudentRemarkFormViewModel model);
        Task<StudentRemarkFormViewModel> GetRemarkFormModelByIdAsync(int id);
    }
} 
