namespace StudentManagementSystem.Core.Models.Teacher
{
    public class TeacherClassesViewModel
    {
        public string TeacherName { get; set; } = string.Empty;
        public IEnumerable<string> Classes { get; set; } = new List<string>();
        public string ClassSearchTerm { get; set; } = string.Empty;
    }
}
