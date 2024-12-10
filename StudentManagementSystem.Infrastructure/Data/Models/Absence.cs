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
        public virtual Student Student { get; set; } = null!;

        [Required]
        [Comment("Course Identifier")]
        public int CourseId { get; set; }

        [ForeignKey(nameof(CourseId))]
        public virtual Course Course { get; set; } = null!;

        [Comment("Shows if absence is Deleted")]
        public bool IsDeleted { get; set; } = false;

        [Required]
        [Comment("Date of Absence")]
        public DateTime Date { get; set; }
    }
}
