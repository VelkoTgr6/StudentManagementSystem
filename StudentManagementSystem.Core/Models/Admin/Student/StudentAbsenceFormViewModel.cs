using StudentManagementSystem.Core.Models.Admin.Course;

namespace StudentManagementSystem.Core.Models.Admin.Student
{
    public class StudentAbsenceFormViewModel
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public int CourseId { get; set; }
        public IEnumerable<CourseServiceModel> Courses { get; set; } = new List<CourseServiceModel>();
        public DateTime AbsenceDate { get; set; } = DateTime.Now;
    }
}
