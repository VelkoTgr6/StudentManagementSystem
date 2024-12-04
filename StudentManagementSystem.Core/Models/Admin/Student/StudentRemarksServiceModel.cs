namespace StudentManagementSystem.Core.Models.Admin.Student
{
    public class StudentRemarksServiceModel
    {
        public int RemarkId { get; set; }
        public string? RemarkText { get; set; }= string.Empty;
        public string? CourseName { get; set; } = string.Empty;
        public int CourseId { get; set; }
    }
}
