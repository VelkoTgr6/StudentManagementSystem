using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Infrastructure.Data.Models
{
    public class Grade
    {
        [Key]
        [Comment("Unique Identifier for the Grade entry")]
        public int Id { get; set; }

        [Comment("Identifier of the Course")]
        public int CourseId { get; set; }

        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; } = null!;

        [Comment("Identifier of the Student")]
        public int StudentId { get; set; }

        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; } = null!;

        [Required]
        [Comment("Grade received by the student for a specific course assessment")]
        public double GradeScore { get; set; }

        [Comment("Date when the grade was assigned")]
        public DateTime GradeAssignedDate { get; set; } = DateTime.Now;

        [Comment("Description or type of the grade (e.g., Midterm, Final, Homework)")]
        [MaxLength(100)]
        public string GradeType { get; set; } = "Assignment"; 
    }
}
