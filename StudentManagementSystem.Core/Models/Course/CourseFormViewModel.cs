using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static StudentManagementSystem.Infrastructure.Constants.ModelConstants;
using static StudentManagementSystem.Core.Constants.ErrorMessageConstants;

namespace StudentManagementSystem.Core.Models.Course
{
    public class CourseFormViewModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [MaxLength(CourseNameMaxLength)]
        [Comment("Course Name")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage=RequiredMessage)]
        [MaxLength(CourseDescriptionMaxLength)]
        [Comment("Course Description")]
        public string Description { get; set; } = null!;

        [Required]
        [Comment("Teacher of the Course")]
        public int TeacherId { get; set; }

        [Required]
        [Comment("Publisher Identification")]
        public string PublisherId { get; set; } = null!;
    }
}
