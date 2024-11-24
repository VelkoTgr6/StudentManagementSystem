namespace StudentManagementSystem.Core.Models.Teacher
{
    public class StudentEditModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public IEnumerable<GradeFormModel> Grades { get; set; } = new List<GradeFormModel>();

    }
}
