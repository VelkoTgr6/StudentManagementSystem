using StudentManagementSystem.Core.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Core.Models.Admin.Teacher
{
    public class AllTeachersQueryModel
    {
        public string SearchTerm { get; set; } = null!;
        public TeacherSorting Sorting { get; set; }
        public int CurrentPage { get; set; } = 1;
        public int TeachersPerPage { get; set; } = 10;
        public IEnumerable<TeacherServiceModel> Teachers { get; set; } = new List<TeacherServiceModel>();
        public string Course { get; init; } = null!;

        [Display(Name = "Search by text")]
        public string SearchBy { get; init; } = null!;
        public int TotalTeachers { get; set; }
        public int TotalTeachersCount { get; set; }
        public int TotalPages { get; set; }
        public IEnumerable<string> Courses { get; set; } = null!;
    }
}
