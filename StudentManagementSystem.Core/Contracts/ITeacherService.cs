using StudentManagementSystem.Core.Models.Teacher;

namespace StudentManagementSystem.Core.Contracts
{
    public interface ITeacherService
    {
        Task<IEnumerable<StudentsViewModel>> GetStudentsByTeacherAndClassAsync(int classId, string userId);
        Task<IEnumerable<StudentsViewModel>> GetStudentsByMainClassTeacherAsync(string userId);
        Task<TeacherClassesViewModel> GetAllClassesByTeacher(string userId);
        Task<TeacherStudentDetailsViewModel> GetStudentDetailsAsync(int studentId,string teacherId);
        Task<TeacherStudentDetailsViewModel> GetMainTeacherStudentDetailsAsync(int studentId);
        Task<int> AddGradeToStudent(GradeFormModel model,int studentId);
        Task<IEnumerable<TeacherCourseServiceModel>> GetTeacherCourses(string teacherId);
        Task<int> AddAbsenceToStudentAsync(AbsenceFormViewModel model, int studentId);
        Task<int> AddRemarkToStudentAsync(RemarkFormViewModel model, int studentId);
        Task<int> GetTeacherEntityIdByUserIdAsync(string userId);
        Task<bool> RemarkOfStudentExists(int studentId,string remarkText,int courseId);
        Task<string> GetCourseNameById(int courseId);
        Task<GradeFormModel> GetGradeByIdAsync(int gradeId);
        Task<int> EditGradeAsync(int gradeId,GradeFormModel model);
        Task DeleteGradeAsync(int gradeId);
        Task<AbsenceFormViewModel> GetAbsenceByIdAsync(int absenceId);
        Task<int> EditAbsenceAsync(int absenceId, AbsenceFormViewModel model);
        Task DeleteAbsenceAsync(int absenceId);
        Task<RemarkFormViewModel> GetRemarkByIdAsync(int remarkId);
        Task<int> EditRemarkASync(int remarkId,RemarkFormViewModel model);
        Task DeleteRemarkAsync(int remarkId);
        Task<IEnumerable<TeacherNewsServiceModel>> GetAllNewsByTeacherIdAsync(string teacherId);
        Task<int> AddNewsToTeacherAsync(TeacherNewsFormViewModel model);
        Task<int> EditNewsAsync(int newsId, TeacherNewsFormViewModel model);
        Task DeleteNewsAsync(int newsId);
        Task<TeacherNewsFormViewModel> GetNewsByIdAsync(int newsId);
    }
}
