using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;
using StudentManagementSystem.Areas.Admin.Controllers;
using StudentManagementSystem.Models;

namespace Tests.Admin
{
    [TestFixture]
    public class AdminUserManageControllerTests
    {
        private Mock<RoleManager<IdentityRole>> roleManagerMock;
        private Mock<UserManager<IdentityUser>> userManagerMock;
        private AdminUserManageController controller;

        [SetUp]
        public void SetUp()
        {
            var roleStore = new Mock<IRoleStore<IdentityRole>>();
            roleManagerMock = new Mock<RoleManager<IdentityRole>>(roleStore.Object, null, null, null, null);

            var userStore = new Mock<IUserStore<IdentityUser>>();
            userManagerMock = new Mock<UserManager<IdentityUser>>(userStore.Object, null, null, null, null, null, null, null, null);

            controller = new AdminUserManageController(roleManagerMock.Object, userManagerMock.Object);
        }

        [TearDown]
        public void Teardown()
        {
            roleManagerMock = null;
            userManagerMock = null;
            if (controller != null)
            {
                controller.Dispose();
                controller = null;
            }
        }

        [Test]
        public void Controller_ShouldNotBeNull()
        {
            Assert.IsNotNull(controller);
        }

        [Test]
        public async Task CreateRole_GetRequest_ReturnsViewResultWithModel()
        {
            
            var result = await controller.CreateRole();

            
            Assert.IsInstanceOf<ViewResult>(result);
            var viewResult = result as ViewResult;
            Assert.IsInstanceOf<RoleFormViewModel>(viewResult.Model);
        }

        [Test]
        public async Task CreateRole_PostRequest_ValidModel_CreatesRoleAndRedirects()
        {
            
            var model = new RoleFormViewModel { RoleName = "TestRole" };
            roleManagerMock.Setup(r => r.RoleExistsAsync(It.IsAny<string>())).ReturnsAsync(false);
            roleManagerMock.Setup(r => r.CreateAsync(It.IsAny<IdentityRole>()))
                           .ReturnsAsync(IdentityResult.Success);

            
            var result = await controller.CreateRole(model);

            
            Assert.IsInstanceOf<RedirectToActionResult>(result);
            var redirectResult = result as RedirectToActionResult;
            Assert.That(redirectResult.ActionName, Is.EqualTo("Index"));
        }

        [Test]
        public async Task CreateRole_PostRequest_RoleAlreadyExists_ReturnsViewWithError()
        {
            
            var model = new RoleFormViewModel { RoleName = "ExistingRole" };
            roleManagerMock.Setup(r => r.RoleExistsAsync(It.IsAny<string>())).ReturnsAsync(true);

            
            var result = await controller.CreateRole(model);

            
            Assert.IsInstanceOf<ViewResult>(result);
            var viewResult = result as ViewResult;
            Assert.That(viewResult, Is.Not.Null);
            Assert.That(viewResult.Model, Is.InstanceOf<RoleFormViewModel>());
            Assert.IsTrue(controller.ModelState.ContainsKey(string.Empty));
        }

        [Test]
        public async Task DeleteRole_ValidRoleName_ReturnsOk()
        {
            
            var roleName = "TestRole";
            var role = new IdentityRole(roleName);
            roleManagerMock.Setup(r => r.FindByNameAsync(roleName)).ReturnsAsync(role);
            roleManagerMock.Setup(r => r.DeleteAsync(role)).ReturnsAsync(IdentityResult.Success);

            
            var result = await controller.DeleteRole(roleName);

            
            Assert.IsInstanceOf<OkResult>(result);
        }

        [Test]
        public async Task DeleteRole_InvalidRoleName_ReturnsBadRequest()
        {
            
            var roleName = "NonExistentRole";
            roleManagerMock.Setup(r => r.FindByNameAsync(roleName)).ReturnsAsync((IdentityRole)null);

            
            var result = await controller.DeleteRole(roleName);

            
            Assert.IsInstanceOf<BadRequestResult>(result);
        }

        [Test]
        public async Task AddUserToRole_Get_ReturnsViewWithCorrectModel()
        {
            
            var users = new List<IdentityUser>
            {
                new IdentityUser { UserName = "User1" },
                new IdentityUser { UserName = "User2" }
            };

            var roles = new List<IdentityRole>
            {
                new IdentityRole("Admin"),
                new IdentityRole("User")
            };

            // Mock UserManager.Users
            userManagerMock.Setup(u => u.Users).Returns(users.AsQueryable());

            // Mock RoleManager.Roles
            roleManagerMock.Setup(r => r.Roles).Returns(roles.AsQueryable());

            
            var result = await controller.AddUserToRole();

            
            Assert.IsInstanceOf<ViewResult>(result);
            var viewResult = result as ViewResult;

            Assert.IsNotNull(viewResult.Model);
            var model = viewResult.Model as UserRoleFormViewModel;

            Assert.IsNotNull(model);
            CollectionAssert.AreEquivalent(users.Select(u => u.UserName).OrderBy(u => u), model.Users);
            CollectionAssert.AreEquivalent(roles.Select(r => r.Name).OrderBy(r => r), model.Roles);
        }

        [Test]
        public async Task AddUserToRole_PostRequest_ValidModel_AddsUserToRoleAndRedirects()
        {
            
            var model = new UserRoleFormViewModel { UserName = "TestUser", RoleName = "TestRole" };
            var user = new IdentityUser { UserName = "TestUser" };

            userManagerMock.Setup(u => u.FindByNameAsync(model.UserName)).ReturnsAsync(user);
            roleManagerMock.Setup(r => r.RoleExistsAsync(model.RoleName)).ReturnsAsync(true);
            userManagerMock.Setup(u => u.IsInRoleAsync(user, model.RoleName)).ReturnsAsync(false);

            
            var result = await controller.AddUserToRole(model);

            
            Assert.IsInstanceOf<RedirectToActionResult>(result);
            var redirectResult = result as RedirectToActionResult;
            Assert.IsNotNull(redirectResult);
            Assert.That(redirectResult.ActionName, Is.EqualTo("Index"));
            Assert.That(redirectResult.ControllerName, Is.EqualTo("AdminHome"));
        }

        [Test]
        public async Task RemoveUserFromRole_PostRequest_UserNotInRole_ReturnsBadRequest()
        {
            
            var model = new UserRoleFormViewModel { UserName = "TestUser", RoleName = "TestRole" };
            var user = new IdentityUser { UserName = "TestUser" };

            userManagerMock.Setup(u => u.FindByNameAsync(model.UserName)).ReturnsAsync(user);
            roleManagerMock.Setup(r => r.RoleExistsAsync(model.RoleName)).ReturnsAsync(true);
            userManagerMock.Setup(u => u.GetRolesAsync(user)).ReturnsAsync(new List<string>());

            
            var result = await controller.RemoveUserFromRole(model);

            
            Assert.IsInstanceOf<BadRequestResult>(result);
        }

        [Test]
        public async Task EditRole_GetRequest_ReturnsViewWithRoles()
        {
            
            var roles = new List<IdentityRole>
            {
                new IdentityRole("Admin"),
                new IdentityRole("User")
            };
            roleManagerMock.Setup(r => r.Roles).Returns(roles.AsQueryable());

            
            var result = await controller.EditRole();

            
            Assert.IsInstanceOf<ViewResult>(result);
            var viewResult = result as ViewResult;

            var model = viewResult.Model as EditRoleViewModel;
            Assert.IsNotNull(model);
            CollectionAssert.AreEquivalent(roles.Select(r => r.Name).OrderBy(n => n), model.Roles);
        }

        [Test]
        public async Task EditRole_PostRequest_ValidModel_UpdatesRoleAndRedirects()
        {
            
            var model = new EditRoleViewModel
            {
                SelectedRoleName = "User",
                NewRoleName = "NewUser"
            };
            var role = new IdentityRole("User");

            roleManagerMock.Setup(r => r.FindByNameAsync("User")).ReturnsAsync(role);
            roleManagerMock.Setup(r => r.UpdateAsync(role)).ReturnsAsync(IdentityResult.Success);

            
            var result = await controller.EditRole(model);

            
            Assert.IsInstanceOf<RedirectToActionResult>(result);
            var redirectResult = result as RedirectToActionResult;
            Assert.That(redirectResult.ActionName, Is.EqualTo("Index"));
            Assert.That(redirectResult.ControllerName, Is.EqualTo("AdminHome"));
        }

        [Test]
        public async Task EditRole_PostRequest_InvalidRole_ReturnsViewWithError()
        {
            
            var model = new EditRoleViewModel
            {
                SelectedRoleName = "NonExistentRole",
                NewRoleName = "UpdatedRole"
            };

            roleManagerMock.Setup(r => r.FindByNameAsync("NonExistentRole")).ReturnsAsync((IdentityRole)null);

            
            var result = await controller.EditRole(model);

            
            Assert.IsInstanceOf<ViewResult>(result);
            var viewResult = result as ViewResult;

            Assert.IsTrue(controller.ModelState.ContainsKey(""));
        }



        [Test]
        public async Task EditRole_PostRequest_UpdateFails_ReturnsViewWithErrors()
        {
            
            var model = new EditRoleViewModel
            {
                SelectedRoleName = "User",
                NewRoleName = "UpdatedRole"
            };
            var role = new IdentityRole("User");

            roleManagerMock.Setup(r => r.FindByNameAsync("User")).ReturnsAsync(role);
            roleManagerMock.Setup(r => r.UpdateAsync(role))
                .ReturnsAsync(IdentityResult.Failed(new IdentityError { Description = "Update failed" }));

            
            var result = await controller.EditRole(model);

            
            Assert.IsInstanceOf<ViewResult>(result);
            var viewResult = result as ViewResult;

            Assert.IsTrue(controller.ModelState.ContainsKey(""));
        }


        [Test]
        public async Task RemoveUserFromRole_GetRequest_ReturnsViewWithUsersAndRoles()
        {
            
            var users = new List<IdentityUser>
            {
                new IdentityUser { UserName = "User1" },
                new IdentityUser { UserName = "User2" }
            };
            var roles = new List<IdentityRole>
            {
                new IdentityRole("Admin"),
                new IdentityRole("User")
            };

            userManagerMock.Setup(u => u.Users).Returns(users.AsQueryable());
            roleManagerMock.Setup(r => r.Roles).Returns(roles.AsQueryable());

            
            var result = await controller.RemoveUserFromRole();

            
            Assert.IsInstanceOf<ViewResult>(result);
            var viewResult = result as ViewResult;

            var model = viewResult.Model as UserRoleFormViewModel;
            Assert.IsNotNull(model);
            CollectionAssert.AreEquivalent(users.Select(u => u.UserName).OrderBy(u => u), model.Users);
            CollectionAssert.AreEquivalent(roles.Select(r => r.Name).OrderBy(r => r), model.Roles);
        }

        [Test]
        public async Task RemoveUserFromRole_PostRequest_ValidRequest_RemovesUserFromRoleAndRedirects()
        {
            
            var model = new UserRoleFormViewModel
            {
                UserName = "User1",
                RoleName = "Admin"
            };
            var user = new IdentityUser { UserName = "User1" };

            roleManagerMock.Setup(r => r.RoleExistsAsync("Admin")).ReturnsAsync(true);
            userManagerMock.Setup(u => u.FindByNameAsync("User1")).ReturnsAsync(user);
            userManagerMock.Setup(u => u.GetRolesAsync(user)).ReturnsAsync(new List<string> { "Admin" });
            userManagerMock.Setup(u => u.RemoveFromRoleAsync(user, "Admin"))
                           .ReturnsAsync(IdentityResult.Success);

            
            var result = await controller.RemoveUserFromRole(model);

            
            Assert.IsInstanceOf<RedirectToActionResult>(result);
            var redirectResult = result as RedirectToActionResult;
            Assert.That(redirectResult.ActionName, Is.EqualTo("Index"));
            Assert.That(redirectResult.ControllerName, Is.EqualTo("AdminHome"));
        }
    }
}


