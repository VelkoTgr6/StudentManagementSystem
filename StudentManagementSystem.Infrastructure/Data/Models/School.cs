using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static StudentManagementSystem.Infrastructure.Constants.ModelConstants;

namespace StudentManagementSystem.Infrastructure.Data.Models
{
    public class School
    {
        [Key]
        [Comment("School Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("School Name")]
        [MaxLength(SchoolNameMaxLength)]
        public string Name { get; set; } = null!;

        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
