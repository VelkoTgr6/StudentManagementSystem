namespace StudentManagementSystem.Core.Models.Teacher
{
    public class TeacherProfileViewModel
    {
        public string SchoolName { get; set; } = string.Empty;
        public string? Titles { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ProfilePicturePath { get; set; } = string.Empty;
        public string ContactDetails { get; set; } = null!;
        public string ClassName { get; set; } = string.Empty;
    }
}
