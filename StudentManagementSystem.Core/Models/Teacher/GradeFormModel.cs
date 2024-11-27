using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Core.Models.Teacher
{
    public class GradeFormModel
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public double GradeScore { get; set; }

        [MaxLength(100)]
        public string GradeType { get; set; } = "Assignment";
        public IEnumerable<TeacherCourseServiceModel> Courses { get; set; } = new List<TeacherCourseServiceModel>();

        public string[] Grades = { "2", "3", "4", "5", "6" };
    }
}
