namespace StudentManagementSystem.Core.Models.Teacher
{
    public class TeacherClassesViewModel
    {
        public string TeacherName { get; set; } = string.Empty;
        public List<TeacherClassServiceViewModel> Classes { get; set; } = new List<TeacherClassServiceViewModel>();
        public string ClassSearchTerm { get; set; } = string.Empty;
    }
}
