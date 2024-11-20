using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static StudentManagementSystem.Infrastructure.Constants.ModelConstants;


namespace StudentManagementSystem.Infrastructure.Data.Models
{
    public class Student
    {
        [Key]
        [Comment("Student Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(StudentPersonalIdMinMaxLength)]
        [Comment("Student Personal Identification Number")]
        public string PersonalId { get; set; } = null!;

        [Required]
        [MaxLength(StudentNameMaxLength)]
        [Comment("Student First Name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(StudentNameMaxLength)]
        [Comment("Student Middle Name")]
        public string MiddleName { get; set; } = null!;

        [Required]
        [MaxLength(StudentNameMaxLength)]
        [Comment("Student Last Name")]
        public string LastName { get; set; }= null!;

        [Required]
        [MaxLength(EmailMaxValue)]
        [Comment("Student Email Address")]
        public string Email { get; set; } = null!;

        [MaxLength(StudentRemarksMaxLength)]
        [Comment("Remarks about the student")]
        public ICollection<Remark> Remarks { get; set; } = new List<Remark>();

        [Comment("Shows if student is Active")]
        public ICollection<Absence> Аbsences { get; set; } = new List<Absence>();

        [Required]
        [Comment("Date of birth of Student")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(StudentContactMaxLength)]
        [Comment("Student Contact Details")]
        public string ContactDetails {  get; set; }= null!;

        [Comment("Shows if student is Deleted")]
        public bool IsDeleted { get; set; } = false;

        [Required]
        [Comment("User Identifier")]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        [Required]
        [Comment("Class Identifier")]
        public int ClassId { get; set; }

        [ForeignKey(nameof(ClassId))]
        public Class Class { get; set; } = null!;

        [MaxLength(ProfilePictureMaxLength)]
        [Comment("Path to the profile picture of the student")]
        public string ProfilePicturePath { get; set; } = "images/profiles/default.png";

        [Comment("Student Performance")]
        public double Performance {  get; set; }

        [Comment("Collection of Grades assigned to the student")]
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
    }
}
