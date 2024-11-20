using StudentManagementSystem.Core.Models.Admin.Course;

namespace StudentManagementSystem.Core.Models.Admin.Teacher
{
    public class TeacherDetailsViewModel
    {
        public int Id { get; set; }
        public string? Titles { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string ProfilePicturePath { get; set; } = null!;
        public string ContactDetails { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int CourseId { get; set; }
        public ICollection<CourseServiceModel> Courses { get; set; } = new List<CourseServiceModel>();
    }
}
