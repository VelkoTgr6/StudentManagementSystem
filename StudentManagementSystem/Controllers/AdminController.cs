using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Core.Models.Student;
using StudentManagementSystem.Infrastructure.Data.Models;
using System.Security.Claims;
using static StudentManagementSystem.Core.Constants.ErrorMessageConstants;

namespace StudentManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService adminService;

        public AdminController(IAdminService _adminService)
        {
            adminService = _adminService;
        }

        public async Task<IActionResult> Index()
        { 
            return View(await adminService.GetAllAsync<Student>());
        }

        // Show the create user form
        public async Task<IActionResult> CreateStudent()
        {
            var model = new StudentFormViewModel()
            {
                Classes =await adminService.AllClassesAsync()
            };
            
            return View(model);
        }

        // Process the create user form
        [HttpPost]
        public async Task<IActionResult> CreateStudent(StudentFormViewModel model)
        {
            if (await adminService.StudentEmailExistAsync(model.Email) == false)
            {
                ModelState.AddModelError(nameof(model.Email), InvalidEmailMessage);
            }

            //var userId = await adminService.GetUserIdByEmail(model.Email);
            //model.UserId = userId;

            if (!ModelState.IsValid)
            {
                model.Classes = await adminService.AllClassesAsync();
                return View(model);
            }

            var id = await adminService.CreateStudentAsync(model);

            return RedirectToAction(nameof(Index));
        }
    }
}
