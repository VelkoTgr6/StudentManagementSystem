using StudentManagementSystem.Core.Models.Course;
using System.ComponentModel.DataAnnotations;
using static StudentManagementSystem.Core.Constants.ErrorMessageConstants;
using static StudentManagementSystem.Infrastructure.Constants.ModelConstants;

namespace StudentManagementSystem.Core.Models.Teacher
{
    public class TeacherFormViewModel
    {
        /// <summary>
        /// Teacher titles
        /// </summary>
        [StringLength(TeacherTitlesMaxLength)]
        public string? Titles { get; set; }

        /// <summary>
        /// Teacher first name
        /// </summary>
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(TeacherNameMaxLength,
            MinimumLength = TeacherContactMinLength,
            ErrorMessage = InvalidLengthMessage)]
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// Teacher Last name
        /// </summary>
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(TeacherNameMaxLength,
            MinimumLength = TeacherContactMinLength,
            ErrorMessage = InvalidLengthMessage)]
        public string LastName { get; set; } = null!;

        /// <summary>
        /// teacher contact details
        /// </summary>
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(TeacherContactMaxLength,
            MinimumLength = TeacherContactMinLength,
            ErrorMessage = InvalidLengthMessage)]
        public string ContactDetails { get; set; } = null!;

        /// <summary>
        /// Teacher email
        /// </summary>
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(StudentEmailMaxValue,
            MinimumLength = StudentEmailMinValue,
            ErrorMessage = InvalidLengthMessage)]
        public string Email { get; set; } = null!;

        /// <summary>
        /// Teacher course id
        /// </summary>
        [Required(ErrorMessage = RequiredMessage)]
        public int CourseId { get; set; }
        public IEnumerable<CourseModel> Courses { get; set; } = new List<CourseModel>();
    }
}
