using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations;
using static StudentManagementSystem.Infrastructure.Constants.ModelConstants;
using static StudentManagementSystem.Core.Constants.ErrorMessageConstants;
using StudentManagementSystem.Core.Models.Admin.Teacher;
using StudentManagementSystem.Core.Models.Admin.Course;

namespace StudentManagementSystem.Core.Models.Admin.Class
{
    public class ClassFormViewModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(CourseDescriptionMaxLength,
            MinimumLength = CourseDescriptionMinLength,
            ErrorMessage = InvalidLengthMessage)]
        [Comment("The name of the class")]
        public string Name { get; set; } = null!;

        [Comment("The collection of courses in the class")]
        public ICollection<ClassCourse> ClassCourses { get; set; } = new List<ClassCourse>();

        [Required]
        [Comment("The ID of the teacher for this class")]
        [Display(Name = "Main Teacher")]
        public int TeacherId { get; set; }
        public IEnumerable<TeacherServiceModel> Teachers { get; set; } = new List<TeacherServiceModel>();

        [Required]
        [Comment("The collection of course IDs selected for this class")]
        public IEnumerable<int> SelectedCourseIds { get; set; } = new List<int>();
        public IEnumerable<CourseServiceModel> AvailableCourses { get; set; } = new List<CourseServiceModel>();
    }
}
