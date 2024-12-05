namespace StudentManagementSystem.Core.Models.Teacher
{
    public class RemarkFormViewModel
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public int CourseId { get; set; }
        public IEnumerable<TeacherCourseServiceModel> Courses { get; set; } = new List<TeacherCourseServiceModel>();
        public string RemarkText { get; set; } = string.Empty;
        public int TeacherId { get; set; }
    }
}
