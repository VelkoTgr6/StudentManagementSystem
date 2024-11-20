using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Infrastructure.Data.Models
{
    public class Absence
    {
        [Key]
        [Comment("Absence Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Student Identifier")]
        public int StudentId { get; set; }

        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; } = null!;

        [Required]
        [Comment("Course Identifier")]
        public int CourseId { get; set; }

        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; } = null!;

        [Required]
        [Comment("Date of Absence")]
        public DateTime Date { get; set; }
    }
}
