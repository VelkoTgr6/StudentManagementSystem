namespace StudentManagementSystem.Core.Models.Teacher
{
    public class TeacherStudentDetailsViewModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public int ClassId { get; set; }
        public string CustomGradeType { get; set; } = string.Empty;
        public List<GradeServiceViewModel> Grades { get; set; } = new List<GradeServiceViewModel>();
        public List<AbsenceServiceViewModel> Absences { get; set; } = new List<AbsenceServiceViewModel>();
        public List<RemarkServiceViewModel> Remarks { get; set; } = new List<RemarkServiceViewModel>();
    }
}
