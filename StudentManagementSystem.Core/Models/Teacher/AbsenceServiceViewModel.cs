namespace StudentManagementSystem.Core.Models.Teacher
{
    public class AbsenceServiceViewModel
    {
        public int Id { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
    }
}
