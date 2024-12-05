using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminUserManageController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;

        public AdminUserManageController(
            RoleManager<IdentityRole> roleManager,
            UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
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
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> AddUserToRole()
        {
            var model = new UserRoleFormViewModel();

            var users = model.Users = userManager.Users.
                    Select(u => u.UserName)
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
                        ModelState.AddModelError("", "The selected user already have role.");

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
                    return RedirectToAction("Index", "AdminHome");
                }
            }
            return BadRequest();
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

            // Find the role using its original name
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

            // Update the role's name
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

            // Redirect to index or a confirmation page
            return RedirectToAction(nameof(Index));
        }



        [HttpGet]
        public async Task<IActionResult> RemoveUserFromRole()
        {
            var model = new UserRoleFormViewModel();

            var users = model.Users = userManager.Users.
                    Select(u => u.UserName)
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
                var users = model.Users = userManager.Users.
                    Select(u => u.UserName)
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
                    if (!await userManager.IsInRoleAsync(user, model.RoleName))
                    {
                        return BadRequest();
                    }
                    await userManager.RemoveFromRoleAsync(user, model.RoleName);

                    return RedirectToAction(nameof(Index));
                }
            }
            return BadRequest();
        }
    }
}
