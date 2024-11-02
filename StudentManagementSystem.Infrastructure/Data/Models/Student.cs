using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
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
        [Comment("Date of birth of Student")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(StudentContactMaxLength)]
        [Comment("Student Contact Details")]
        public string ContactDetails {  get; set; }= null!;

        [Comment("Courses that student enrolled")]
        public ICollection<Course> CoursesEnrolled { get; set; } = new List<Course>();

        [Comment("Student Performance")]
        public double Performance {  get; set; }

        [Comment("Collection of Grades assigned to the student")]
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
    }
}
