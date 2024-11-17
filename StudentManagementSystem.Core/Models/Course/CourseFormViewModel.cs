using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static StudentManagementSystem.Infrastructure.Constants.ModelConstants;
using static StudentManagementSystem.Core.Constants.ErrorMessageConstants;
using StudentManagementSystem.Core.Models.Teacher;

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
        [Display(Name = "Teacher")]
        public int TeacherId { get; set; }

        public IEnumerable<TeacherServiceModel> Teachers { get; set; } = new List<TeacherServiceModel>();
    }
}
