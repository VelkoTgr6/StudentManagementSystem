using StudentManagementSystem.Core.Models.Admin.Course;

namespace StudentManagementSystem.Core.Models.Admin.Teacher
{
    public class TeacherServiceModel
    {
        public int Id { get; set; }
        public string SchoolName { get; set; } = null!;
        public string Titles { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string ContactDetails { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public IEnumerable<CourseServiceModel> Courses { get; set; } = null!;
    }
}
