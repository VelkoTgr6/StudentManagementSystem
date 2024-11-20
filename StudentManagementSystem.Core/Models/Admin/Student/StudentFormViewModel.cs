using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static StudentManagementSystem.Infrastructure.Constants.ModelConstants;
using static StudentManagementSystem.Core.Constants.ErrorMessageConstants;
using StudentManagementSystem.Core.Models.Admin.Course;
using StudentManagementSystem.Core.Models.Admin.Class;

namespace StudentManagementSystem.Core.Models.Admin.Student
{
    public class StudentFormViewModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(StudentPersonalIdMinMaxLength,
            MinimumLength = StudentPersonalIdMinMaxLength,
            ErrorMessage = InvalidPersonalIdLengthMessage)]
        [Comment("Student Personal Identification Number")]
        [Display(Name = "Personal Identification Number")]
        public string PersonalId { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(StudentNameMaxLength,
            MinimumLength = StudentNameMinLength,
            ErrorMessage = InvalidLengthMessage)]
        [Comment("Student First Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(StudentNameMaxLength,
            MinimumLength = StudentNameMinLength,
            ErrorMessage = InvalidLengthMessage)]
        [Comment("Student Middle Name")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; } = null!;

        [Required]
        [StringLength(StudentNameMaxLength,
            MinimumLength = StudentNameMinLength,
            ErrorMessage = InvalidLengthMessage)]
        [Comment("Student Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(EmailMaxValue,
            MinimumLength = EmailMinValue,
            ErrorMessage = InvalidLengthMessage)]
        [Comment("Student Email Address")]
        public string Email { get; set; } = null!;

        [Required]
        [Comment("Date of birth of Student")]
        // [RegularExpression(RegexDateFormat, ErrorMessage = "Date format should be MM/dd/yyyy")]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(StudentContactMaxLength,
            MinimumLength = StudentContactMinLength,
            ErrorMessage = InvalidLengthMessage)]
        [Comment("Student Contact Details")]
        [Display(Name = "Contact Details")]
        public string ContactDetails { get; set; } = null!;

        [Comment("Student Profile Picture Path")]
        [Display(Name = "Profile Picture")]
        public string ProfilePicturePath { get; set; } = "images/profiles/default.png";

        [Comment("Class Identifier")]
        [Display(Name = "Class")]
        public int ClassId { get; set; }
        public IEnumerable<ClassServiceModel> Classes { get; set; } = new List<ClassServiceModel>();
    }
}
