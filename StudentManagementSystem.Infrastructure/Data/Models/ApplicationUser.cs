using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static StudentManagementSystem.Infrastructure.Constants.ModelConstants;

namespace StudentManagementSystem.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(StudentPersonalIdMinMaxLength)]
        [Comment("Personal ID is a unique identifier for each person.")]
        public string PersonalId { get; set; } = null!;

        [MaxLength(StudentNameMaxLength)]
        [Comment("First name of the user.")]
        public string? FirstName { get; set; }

        [MaxLength(StudentNameMaxLength)]
        [Comment("Last name of the user.")]
        public string? LastName { get; set; }
    }
}
