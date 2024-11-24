using System.ComponentModel.DataAnnotations;
using static StudentManagementSystem.Core.Constants.ErrorMessageConstants;

namespace StudentManagementSystem.Models
{
    public class UserRoleFormViewModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(50,
            MinimumLength = 5,
            ErrorMessage = InvalidLengthMessage)]
        [Display(Name = "User Name")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(50,
            MinimumLength = 5,
            ErrorMessage = InvalidLengthMessage)]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; } = string.Empty;

        public IEnumerable<string?> Users { get; set; } = new List<string>();
        public IEnumerable<string?> Roles { get; set; } = new List<string>();
    }
}
