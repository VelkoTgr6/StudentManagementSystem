namespace StudentManagementSystem.Core.Models.Teacher
{
    public class AbsenceFormViewModel
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public int CourseId { get; set; }
        public IEnumerable<TeacherCourseServiceModel> Courses { get; set; } = new List<TeacherCourseServiceModel>();
        public DateTime AbsenceDate { get; set; } = DateTime.Now;
    }
}
