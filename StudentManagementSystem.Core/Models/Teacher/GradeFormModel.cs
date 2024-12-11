using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Core.Models.Teacher
{
    public class GradeFormModel
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public double GradeScore { get; set; }
        public int GradeId { get; set; }
        public string ?CustomGradeType { get; set; }

        [MaxLength(100)]
        public string GradeType { get; set; } = string.Empty;
        public string SelectedGrade { get; set; } = string.Empty;
        public int SelectedCourseId { get; set; }
        public string SelectedGradeType { get; set; } = string.Empty;
        public IEnumerable<TeacherCourseServiceModel> Courses { get; set; } = new List<TeacherCourseServiceModel>();

        public string[] Grades = { "2", "3", "4", "5", "6" };
    }
}
