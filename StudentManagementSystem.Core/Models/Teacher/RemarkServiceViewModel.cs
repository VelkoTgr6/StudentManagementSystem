namespace StudentManagementSystem.Core.Models.Teacher
{
    public class RemarkServiceViewModel
    {
        public int Id { get; set; }
        public string RemarkText { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public int TeacherId { get; set; }
    }
}
