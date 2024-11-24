using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class RoleFormViewModel
    {
        [Required]
        [StringLength(50)]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; } = string.Empty;
    }
}
