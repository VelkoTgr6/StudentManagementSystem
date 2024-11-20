using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Infrastructure.Data.Models
{
    [PrimaryKey(nameof(ClassId), nameof(CourseId))]
    public class ClassCourse
    {
        [Comment("Class Identifier")]
        public int ClassId { get; set; }

        [ForeignKey(nameof(ClassId))]
        public Class Class { get; set; } = null!;

        [Comment("Course Identifier")]
        public int CourseId { get; set; }

        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; } = null!;

        [Comment("Date of enrollment")]
        public DateTime EnrollmentDate { get; set; }
    }
}
