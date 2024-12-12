namespace StudentManagementSystem.Core.Models.Admin.Schedule
{
    public class CourseScheduleViewModel
    {
        public int Id { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public string Day { get; set; } = string.Empty;
        public string StartTime { get; set; } = string.Empty;
        public string EndTime { get; set; } = string.Empty;
    }
}
