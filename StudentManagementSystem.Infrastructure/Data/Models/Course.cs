using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static StudentManagementSystem.Infrastructure.Constants.ModelConstants;

namespace StudentManagementSystem.Infrastructure.Data.Models
{
    public class Course
    {
        [Key]
        [Comment("Course Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CourseNameMaxLength)]
        [Comment("Course Name")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(CourseDescriptionMaxLength)]
        [Comment("Course Description")]
        public string Description { get; set; } = null!;

        [Comment("Shows if course is Deleted")]
        public bool IsDeleted { get; set; } = false;

        [Comment("Course Start Date")]
        public DateTime StartDate { get; set; }

        [Comment("Course End Date")]
        public DateTime EndDate { get; set; }

        [Comment("Maximum number of students allowed")]
        public int EnrollmentCap { get; set; }

        [Comment("Teacher of the Course")]
        public int? TeacherId {  get; set; }

        [ForeignKey(nameof(TeacherId))]
        [Comment("Teacher of the Course")]
        public Teacher Teacher { get; set; } = null!;

        [Required]
        [Comment("Publisher Identification")]
        public string PublisherId { get; set; } = null!;

        [ForeignKey(nameof(PublisherId))]
        public IdentityUser Publisher { get; set; } = null!;

        public ICollection<ClassCourse> CourseClasses { get; set; } = new List<ClassCourse>();

        [Comment("Grades assigned to the course")]
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();

    }
}
