using StudentManagementSystem.Core.Models.Admin.Student;

namespace StudentManagementSystem.Core.Models.Admin.Class
{
    public class ClassServiceModel
    {
        /// <summary>
        /// Class Identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Class Name
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Class Teacher
        /// </summary>
        public string Teacher { get; set; } = null!;

        /// <summary>
        /// Class Students Count
        /// </summary>
        public int StudentsCount { get; set; }
    }
}
