using StudentManagementSystem.Core.Models.Admin.Course;

namespace StudentManagementSystem.Core.Models.Admin.Student
{
    public class StudentRemarkFormViewModel
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public int CourseId { get; set; }
        public IEnumerable<CourseServiceModel> Courses { get; set; } = new List<CourseServiceModel>();
        public string RemarkText { get; set; } = string.Empty;
        public int TeacherId { get; set; }
    }
}
