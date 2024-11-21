namespace StudentManagementSystem.Core.Models.Admin.Course
{
    public class CourseQueryServiceModel
    {
        public IEnumerable<CourseServiceModel> Courses { get; set; } = new List<CourseServiceModel>();
        public int TotalCoursesCount { get; set; }
    }
}
