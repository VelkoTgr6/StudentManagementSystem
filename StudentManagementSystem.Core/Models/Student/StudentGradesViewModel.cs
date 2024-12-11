namespace StudentManagementSystem.Core.Models.Student
{
    public class StudentGradesViewModel
    {
        public string CourseName { get; set; } = string.Empty;
        public IEnumerable<GradeServiceModel> Grades { get; set; } = new List<GradeServiceModel>();
        public string AverageGrade { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
    }
}
