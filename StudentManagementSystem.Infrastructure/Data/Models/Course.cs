using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static StudentManageApp.Infrastructure.Constants.ModelConstants;



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

        [Required]
        [Comment("Teacher of the Course")]
        public int TeacherId {  get; set; }

        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; } = null!;

        [Required]
        [Comment("Publisher Identification")]
        public string PublisherId { get; set; } = null!;

        [ForeignKey(nameof(PublisherId))]
        public IdentityUser Publisher { get; set; } = null!;

        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

    }
}
