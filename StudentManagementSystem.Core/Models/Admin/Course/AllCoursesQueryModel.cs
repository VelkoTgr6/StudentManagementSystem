using StudentManagementSystem.Core.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Core.Models.Admin.Course
{
    public class AllCoursesQueryModel
    {
        public string SearchTerm { get; set; } = null!;
        public CourseSorting Sorting { get; init; }
        public string Teacher { get; init; } = null!;

        [Display(Name = "Search by text")]
        public string SearchBy { get; init; } = null!;
        public int CurrentPage { get; set; } = 1;
        public int TotalCourses { get; set; }
        public int CoursesPerPage { get; set; } = 10;
        public int TotalCoursesCount { get; set; }
        public int TotalPages { get; set; }
        public IEnumerable<CourseServiceModel> Courses { get; set; } = new List<CourseServiceModel>();
        public IEnumerable<string> Teachers { get; set; } = new List<string>();
    }
}
