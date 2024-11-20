using StudentManagementSystem.Core.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Core.Models.Admin.Student
{
    public class AllStudentsQueryModel
    {
        public string SearchTerm { get; set; } = null!;
        public StudentSorting Sorting { get; init; }
        public string Class { get; init; } = null!;

        [Display(Name = "Performance")]
        public string GradesPerformance { get; init; } = null!;

        [Display(Name = "Search by text")]
        public string SearchBy { get; init; } = null!;
        public int CurrentPage { get; set; } = 1;
        public int TotalStudents { get; set; }
        public int StudentsPerPage { get; set; } = 10;
        public int TotalStudentsCount { get; set; }
        public int TotalPages { get; set; }
        public IEnumerable<StudentServiceModel> Students { get; set; } = new List<StudentServiceModel>();
        public IEnumerable<string> Classes { get; set; } = null!;

    }
}
