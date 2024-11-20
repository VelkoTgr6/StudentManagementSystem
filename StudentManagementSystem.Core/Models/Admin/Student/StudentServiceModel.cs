using StudentManagementSystem.Core.Models.Admin.Class;

namespace StudentManagementSystem.Core.Models.Admin.Student
{
    public class StudentServiceModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string ContactDetails { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PersonalId { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string Class { get; set; } = null!;
        public double Performance { get; set; }
        public IEnumerable<ClassServiceModel> Classes { get; set; } = new List<ClassServiceModel>();
    }
}
