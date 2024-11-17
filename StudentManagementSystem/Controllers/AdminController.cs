using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Core.Models.Course;
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

        [HttpGet]
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

            if (!ModelState.IsValid)
            {
                model.Classes = await adminService.AllClassesAsync();
                return View(model);
            }

            var id = await adminService.CreateStudentAsync(model);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> CreateCourse()
        {
            var model = new CourseFormViewModel()
            {
                Teachers = await adminService.AllTeachersAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse(CourseFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Teachers = await adminService.AllTeachersAsync();
                return View(model);
            }

            var publisherId = User.GetId();

            var id = await adminService.CreateCourseAsync(model, publisherId);

            return RedirectToAction(nameof(Index));
        }
    }
}
