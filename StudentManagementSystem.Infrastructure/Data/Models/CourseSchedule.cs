using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Infrastructure.Data.Models
{
    public class CourseSchedule
    {
        [Key]
        [Comment("Course Schedule Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Course Identifier")]
        public int CourseId { get; set; }

        [ForeignKey(nameof(CourseId))]
        public virtual Course Course { get; set; } = null!;

        [Required]
        [Comment("Class Identifier")]
        public int ClassId { get; set; }

        [ForeignKey(nameof(ClassId))]
        public virtual Class Class { get; set; } = null!;

        [Required]
        [Comment("Day of the week")]
        public DayOfWeek Day { get; set; }

        [Required]
        [Comment("Start Time")]
        public TimeSpan StartTime { get; set; }

        [Required]
        [Comment("End Time")]
        public TimeSpan EndTime { get; set; }
    }
}
