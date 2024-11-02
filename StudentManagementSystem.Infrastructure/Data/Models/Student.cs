using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static StudentManageApp.Infrastructure.Constants.ModelConstants;


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
        [MaxLength(StudentEmailMaxValue)]
        [Comment("Student Email Address")]
        public string Email { get; set; } = null!;

        [Required]
        [Comment("Date of birth of Student")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(StudentContactMaxLength)]
        [Comment("Student Contact Details")]
        public string ContactDetails {  get; set; }= null!;

        [Required]
        [Comment("User Identifier")]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        [Comment("Courses that student enrolled")]
        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

        [Comment("Student Performance")]
        public double Performance {  get; set; }

        [Comment("Collection of Grades assigned to the student")]
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
    }
}
