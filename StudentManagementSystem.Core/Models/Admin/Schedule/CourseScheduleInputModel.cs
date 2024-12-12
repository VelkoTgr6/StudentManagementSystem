using StudentManagementSystem.Core.Models.Admin.Class;
using StudentManagementSystem.Core.Models.Admin.Course;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Core.Models.Admin.Schedule
{
    public class CourseScheduleInputModel
    {
        public int CourseId { get; set; }
        public int ClassId { get; set; }

        [Required]
        public DayOfWeek Day { get; set; }

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        public TimeSpan EndTime { get; set; }

        public int SelectedCourseId { get; set; }
        public int SelectedClassId { get; set; }
        public DayOfWeek SelectedDay { get; set; }
        public TimeSpan SelectedStartTime { get; set; }
        public TimeSpan SelectedEndTime { get; set; }

        public IEnumerable<CourseServiceModel> Courses { get; set; } = new List<CourseServiceModel>();
        public IEnumerable<ClassServiceModel> Classes { get; set; } = new List<ClassServiceModel>();
    }
}
