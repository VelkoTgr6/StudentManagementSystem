namespace StudentManagementSystem.Core.Models.Teacher
{
    public class GradeFormModel
    {
        public string StudentId { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
        public int CourseId { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public int Grade { get; set; }
    }
}
