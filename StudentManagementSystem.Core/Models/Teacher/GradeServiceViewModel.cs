namespace StudentManagementSystem.Core.Models.Teacher
{
    public class GradeServiceViewModel
    {
        public int Id { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public string GradeScore { get; set; } = string.Empty;
        public string GradeType { get; set; } = string.Empty;
    }
}
