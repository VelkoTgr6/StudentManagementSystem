using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class EditRoleViewModel
    {
        public IEnumerable<string?> Roles { get; set; } = new List<string>();
        public string SelectedRoleName { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        [Display(Name = "New Role Name")]
        public string NewRoleName { get; set; } = string.Empty;
    }
}
