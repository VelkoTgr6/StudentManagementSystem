namespace StudentManagementSystem.Core.Models.Admin.Student
{
    public class StudentQueryServiceModel
    {
        public IEnumerable<StudentServiceModel> Students { get; set; } = new List<StudentServiceModel>();
        public int TotalStudentsCount { get; set; }
    }
}
