using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Core.Models.Teacher
{
    public class TeacherNewsFormViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;
        public string TeacherId { get; set; } = string.Empty;
    }
}
