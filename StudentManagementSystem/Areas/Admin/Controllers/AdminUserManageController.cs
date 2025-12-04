using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class AdminUserManageController : Controller
    {
        private readonly RoleManager<IdentityRole<string>> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly ILogger<AdminUserManageController> logger;

        public AdminUserManageController(
            RoleManager<IdentityRole<string>> _roleManager,
            UserManager<IdentityUser> _userManager,
            ILogger<AdminUserManageController> _logger)
        {
            roleManager = _roleManager;
            userManager = _userManager;
            logger = _logger;
        }

        [HttpGet]
        public async Task<IActionResult> CreateRole()
        {
            var model = new RoleFormViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (await roleManager.RoleExistsAsync(model.RoleName))
            {
                ModelState.AddModelError(string.Empty, "Role already exists.");
                return View(model);
            }

            var role = new IdentityRole(model.RoleName);
            var result = await roleManager.CreateAsync(role);

            if (result.Succeeded)
            {
                logger.LogInformation($"Role {model.RoleName} created successfully.");
                return RedirectToAction(nameof(Index));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }


            return View(model);
        }

        public async Task<IActionResult> DeleteRole(string roleName)
        {
            var role = await roleManager.FindByNameAsync(roleName);

            if (role != null)
            {
                await roleManager.DeleteAsync(role);

                logger.LogInformation($"Role {roleName} deleted successfully.");

                return Ok();
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> AddUserToRole()
        {
            var model = new UserRoleFormViewModel();

            var users = model.Users = userManager.Users
                   .Where(u => !string.IsNullOrEmpty(u.UserName))
                   .Select(u => u.UserName)
                   .OrderBy(u => u)
                   .ToList();

            var roles = model.Roles = roleManager.Roles
                 .Select(r => r.Name)
                 .OrderBy(r => r)
                 .ToList();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddUserToRole(UserRoleFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var users = model.Users = userManager.Users
                    .Where(u => !string.IsNullOrEmpty(u.UserName))
                    .Select(u => u.UserName)
                    .OrderBy(u => u)
                    .ToList();

                var roles = model.Roles = roleManager.Roles
                     .Select(r => r.Name)
                     .OrderBy(r => r)
                     .ToList();

                return View(model);
            }

            if (await roleManager.RoleExistsAsync(model.RoleName))
            {
                var user = await userManager.FindByNameAsync(model.UserName);

                if (user != null)
                {
                    if (await userManager.IsInRoleAsync(user, model.RoleName))
                    {
                        ModelState.AddModelError("", "The selected user already has a role.");

                        var users = model.Users = userManager.Users
                            .Select(u => u.UserName)
                            .OrderBy(u => u)
                            .ToList();

                        var roles = model.Roles = roleManager.Roles
                             .Select(r => r.Name)
                             .OrderBy(r => r)
                             .ToList();
                        return View(model);
                    }

                    await userManager.AddToRoleAsync(user, model.RoleName);

                    logger.LogInformation($"User {model.UserName} added to role {model.RoleName}.");

                    return RedirectToAction("Index", "AdminHome");
                }
            }

            logger.LogWarning("Role or user not found.");

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> EditRole()
        {
            var model = new EditRoleViewModel
            {
                Roles = roleManager.Roles
                    .Select(r => r.Name)
                    .OrderBy(r => r)
                    .ToList()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Roles = roleManager.Roles
                    .Select(r => r.Name)
                    .OrderBy(r => r)
                    .ToList();

                return View(model);
            }

            var selectedRole = await roleManager.FindByNameAsync(model.SelectedRoleName);

            if (selectedRole == null)
            {
                ModelState.AddModelError("", "The selected role does not exist.");

                model.Roles = roleManager.Roles
                    .Select(r => r.Name)
                    .OrderBy(r => r)
                    .ToList();

                return View(model);
            }

            selectedRole.Name = model.NewRoleName;
            selectedRole.NormalizedName = model.NewRoleName.ToUpperInvariant();

            var result = await roleManager.UpdateAsync(selectedRole);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                model.Roles = roleManager.Roles
                    .Select(r => r.Name)
                    .OrderBy(r => r)
                    .ToList();

                return View(model);
            }

            logger.LogInformation($"Role {model.SelectedRoleName} renamed to {model.NewRoleName}.");

            return RedirectToAction("Index", "AdminHome");
        }

        [HttpGet]
        public async Task<IActionResult> RemoveUserFromRole()
        {
            var model = new UserRoleFormViewModel();

            var users = model.Users = userManager.Users
                   .Where(u => !string.IsNullOrEmpty(u.UserName))
                   .Select(u => u.UserName)
                   .OrderBy(u => u)
                   .ToList();

            var roles = model.Roles = roleManager.Roles
                 .Select(r => r.Name)
                 .OrderBy(r => r)
                 .ToList();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveUserFromRole(UserRoleFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var users = model.Users = userManager.Users
                   .Where(u => !string.IsNullOrEmpty(u.UserName))
                   .Select(u => u.UserName)
                   .OrderBy(u => u)
                   .ToList();

                var roles = model.Roles = roleManager.Roles
                     .Select(r => r.Name)
                     .OrderBy(r => r)
                     .ToList();

                return View(model);
            }
            if (await roleManager.RoleExistsAsync(model.RoleName))
            {
                var user = await userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    var userRoles = await userManager.GetRolesAsync(user);
                    if (!userRoles.Contains(model.RoleName))
                    {
                        ModelState.AddModelError("", "The selected user does not have the selected role.");
                        var users = model.Users = userManager.Users
                            .Where(u => !string.IsNullOrEmpty(u.UserName))
                            .Select(u => u.UserName)
                            .OrderBy(u => u)
                            .ToList();

                        var roles = model.Roles = roleManager.Roles
                             .Select(r => r.Name)
                             .OrderBy(r => r)
                             .ToList();

                        return View(model);
                    }
                    await userManager.RemoveFromRoleAsync(user, model.RoleName);

                    logger.LogInformation($"User {model.UserName} removed from role {model.RoleName}.");

                    return RedirectToAction("Index", "AdminHome");
                }
            }
            return NotFound();
        }


    }
}
