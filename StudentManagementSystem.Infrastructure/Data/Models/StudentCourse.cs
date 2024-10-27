using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Infrastructure.Data.Models
{
    [PrimaryKey(nameof(StudentId), nameof(CourseId))]
    public class StudentCourse
    {
        [Comment("Student Identifier")]
        public int StudentId { get; set; }

        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; } = null!;

        [Comment("Course Identifier")]
        public int CourseId { get; set; }

        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; } = null!;

        [Comment("Date of enrollment")]
        public DateTime EnrollmentDate { get; set; }
    }
}
