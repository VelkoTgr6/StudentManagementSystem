using StudentManagementSystem.Core.Models.Admin.Course;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Core.Models.Admin.Student
{
    public class StudentGradeFormViewModel
    {
        public int GradeId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public double GradeScore { get; set; }
        public string? CustomGradeType { get; set; }

        [MaxLength(50)]
        public string GradeType { get; set; } = string.Empty;
        public IEnumerable<CourseServiceModel> Courses { get; set; } = new List<CourseServiceModel>();

        public string[] Grades = { "2", "3", "4", "5", "6" };
    }
}
