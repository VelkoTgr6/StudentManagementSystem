using StudentManagementSystem.Core.Enumerations;
using StudentManagementSystem.Core.Models.Admin.Course;
using StudentManagementSystem.Core.Models.Admin.Student;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Core.Models.Admin.Class
{
    public class AllClassesQueryModel
    {
        public string SearchTerm { get; set; } = null!;
        public ClassSorting Sorting { get; init; }
        public string Teacher { get; init; } = null!;

        [Display(Name = "Search by text")]
        public string SearchBy { get; init; } = null!;
        public int CurrentPage { get; set; } = 1;
        public int TotalClasses { get; set; }
        public int ClassesPerPage { get; set; } = 10;
        public int TotalClassesCount { get; set; }
        public int TotalPages { get; set; }
        public int StudentsCount { get; set; }
        public IEnumerable<ClassServiceModel> Classes { get; set; } = new List<ClassServiceModel>();
        public IEnumerable<string> Teachers { get; set; } = null!;
        public IEnumerable<string> Students { get; set; } = new List<string>();
    }
}
