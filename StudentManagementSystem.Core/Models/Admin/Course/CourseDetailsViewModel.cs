namespace StudentManagementSystem.Core.Models.Admin.Course
{
    public class CourseDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Teacher { get; set; } = null!;
    }
}
