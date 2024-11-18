using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static StudentManagementSystem.Infrastructure.Constants.ModelConstants;

namespace StudentManagementSystem.Infrastructure.Data.Models
{
    public class Teacher
    {
        [Key]
        [Comment("Teacher Identifier")]
        public int Id { get; set; }

        [MaxLength(TeacherTitlesMaxLength)]
        [Comment("Teacher Titles")]
        public string? Titles { get; set; }

        [Required]
        [MaxLength(TeacherNameMaxLength)]
        [Comment("Teacher First Name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(TeacherNameMaxLength)]
        [Comment("Teacher Last Name")]
        public string LastName { get; set; } = null!;

        [Comment("Shows if teacher is Deleted")]
        public bool IsDeleted { get; set; } = false;

        [Required]
        [MaxLength(EmailMaxValue)]
        [Comment("Student Email Address")]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(ProfilePictureMaxLength)]
        [Comment("Path to the profile picture of the student")]
        public string ProfilePicturePath { get; set; } = "images/profiles/default.png";

        [Required]
        [Comment("User Identifier")]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        [Required]
        [MaxLength(TeacherContactMaxLength)]
        [Comment("Teacher Contact Details")]
        public string ContactDetails { get; set; } = null!;

        [Comment("The courses taught by this teacher")]
        public ICollection<Course> Courses { get; set; } = new List<Course>();

        [Comment("The classes taught by this teacher")]
        public ICollection<Class> Classes { get; set; } = new List<Class>();
    }
}
