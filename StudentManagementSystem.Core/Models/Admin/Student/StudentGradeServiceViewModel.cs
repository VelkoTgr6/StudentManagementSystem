namespace StudentManagementSystem.Core.Models.Admin.Student
{
    public class StudentGradeServiceViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } =string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public string Grade { get; set; } = string.Empty;
        public string GradeType { get; set; } = string.Empty;
        public DateTime DateAdded { get; set; }
    }
}
