using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static StudentManagementSystem.Infrastructure.Constants.ModelConstants;

namespace StudentManagementSystem.Infrastructure.Data.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(CourseDescriptionMaxLength)]
        [Comment("The name of the class")]
        public string Name { get; set; } = null!;

        [Comment("The collection of students in the class")]
        public ICollection<Student> Students { get; set; } = new List<Student>();

        [Comment("The collection of courses in the class")]
        public ICollection<ClassCourse> ClassCourses { get; set; } = new List<ClassCourse>();

        [Required]
        [Comment("The ID of the teacher for this class")]
        public int TeacherId { get; set; }

        [ForeignKey(nameof(TeacherId))]
        [Comment("The teacher of the class")]
        public Teacher Teacher { get; set; } = null!;

        [Comment("Shows if class is Deleted")]
        public bool IsDeleted { get; set; } = false;

    }
}
