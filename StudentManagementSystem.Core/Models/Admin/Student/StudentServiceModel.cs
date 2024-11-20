using StudentManagementSystem.Core.Models.Admin.Class;

namespace StudentManagementSystem.Core.Models.Admin.Student
{
    public class StudentServiceModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ContactDetails { get; set; }
        public string Email { get; set; }
        public string PersonalId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Class { get; set; }
        public double Performance { get; set; }
        public IEnumerable<ClassServiceModel> Classes { get; set; } = new List<ClassServiceModel>();
    }
}
