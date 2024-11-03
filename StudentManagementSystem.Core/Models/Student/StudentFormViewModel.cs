using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static StudentManageApp.Infrastructure.Constants.ModelConstants;
using static StudentManagementSystem.Core.Constants.ErrorMessageConstants;

namespace StudentManagementSystem.Core.Models.Student
{
    public class StudentFormViewModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [Comment("Student Identifier")]
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(StudentPersonalIdMinMaxLength,
            MinimumLength = StudentPersonalIdMinMaxLength,
            ErrorMessage = InvalidPersonalIdLengthMessage)]
        [Comment("Student Personal Identification Number")]
        public string PersonalId { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(StudentNameMaxLength,
            MinimumLength = StudentNameMinLength,
            ErrorMessage = InvalidLengthMessage)]
        [Comment("Student First Name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(StudentNameMaxLength,
            MinimumLength = StudentNameMinLength,
            ErrorMessage = InvalidLengthMessage)]
        [Comment("Student Middle Name")]
        public string MiddleName { get; set; } = null!;

        [Required]
        [StringLength(StudentNameMaxLength,
            MinimumLength = StudentNameMinLength,
            ErrorMessage = InvalidLengthMessage)]
        [Comment("Student Last Name")]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(StudentEmailMaxValue,
            MinimumLength = StudentEmailMinValue,
            ErrorMessage = InvalidLengthMessage)]
        [Comment("Student Email Address")]
        public string Email { get; set; } = null!;

        [Required]
        [Comment("Date of birth of Student")]
        [RegularExpression(RegexDateFormat, ErrorMessage = "Date format should be yyyy.MM.dd")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(StudentContactMaxLength,
            MinimumLength = StudentContactMinLength,
            ErrorMessage = InvalidLengthMessage)]
        [Comment("Student Contact Details")]
        public string ContactDetails { get; set; } = null!;

        [Required]
        [Comment("User Identifier")]
        public string UserId { get; set; } = null!;
    }
}
