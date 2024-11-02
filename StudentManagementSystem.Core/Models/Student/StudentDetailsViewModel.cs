using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Core.Models.Student
{
    public class StudentDetailsViewModel
    {
        public int Id { get; set; }
        public string PersonalId { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string ContactDetails { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string CoursesEnrolled { get; set; } = null!;
        public string Performance { get; set; }

        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
    }
}
