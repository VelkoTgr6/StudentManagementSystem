namespace StudentManagementSystem.Core.Models.Teacher
{
    public class TeacherNewsServiceModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; }
        public string TeacherId { get; set; } = string.Empty;
    }
}
