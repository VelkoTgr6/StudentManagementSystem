namespace StudentManagementSystem.Core.Models.Course
{
    public class CourseModel
    {
        /// <summary>
        /// Course Identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Course Name
        /// </summary>
        public string Name { get; set; } = null!;
    }
}
