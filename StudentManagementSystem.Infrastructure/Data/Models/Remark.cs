using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Infrastructure.Data.Models
{
    public class Remark
    {
        [Key]
        [Comment("Remark Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Remark Text")]
        [MaxLength(500)]
        public string RemarkText { get; set; } = null!;

        [Comment("Shows if remark is Deleted")]
        public bool IsDeleted { get; set; } = false;

        [Required]
        [Comment("Student Identifier")]
        public int StudentId { get; set; }

        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; } = null!;

        [Required]
        [Comment("Teacher Identifier")]
        public int TeacherId { get; set; }

        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; } = null!;

        [Required]
        [Comment("Course Identifier")]
        public int CourseId { get; set; }

        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; } = null!;
    }
}
