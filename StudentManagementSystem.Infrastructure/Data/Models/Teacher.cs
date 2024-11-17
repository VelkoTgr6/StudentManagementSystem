using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static StudentManagementSystem.Infrastructure.Constants.ModelConstants;

namespace StudentManagementSystem.Infrastructure.Data.Models 
{ 
    public class Teacher
    {
        [Key]
        [Comment("Teacher Identifier")]
        public int Id { get; set; }

        [MaxLength(TeacherTitlesMaxLength)]
        [Comment("Teacher Titles")]
        public string? Titles {  get; set; }

        [Required]
        [MaxLength(TeacherNameMaxLength)]
        [Comment("Teacher First Name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(TeacherNameMaxLength)]
        [Comment("Teacher Last Name")]
        public string LastName { get; set;} = null!;

        [Comment("Shows if teacher is Deleted")]
        public bool IsDeleted { get; set; } = false;

        [Required]
        [MaxLength(TeacherContactMaxLength)]
        [Comment("Teacher Contact Details")]
        public string ContactDetails { get; set; } = null!;

        [Comment("The collection of classes taught by this teacher")]
        public ICollection<Class> Classes { get; set; } = new List<Class>();
    }
}
