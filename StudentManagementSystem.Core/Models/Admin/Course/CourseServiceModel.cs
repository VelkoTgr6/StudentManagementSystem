namespace StudentManagementSystem.Core.Models.Admin.Course
{
    public class CourseServiceModel
    {
        /// <summary>
        /// Course Identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Course Name
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Course Teacher
        /// </summary>
        public string Teacher { get; set; } = null!;
    }
}
