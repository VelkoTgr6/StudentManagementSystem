using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Core.Models.Student;
using StudentManagementSystem.Infrastructure.Data.Models;

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
        public IActionResult Create()
        {
            var model = new StudentFormViewModel();
            return View(model);
        }

        // Process the create user form
        [HttpPost]
        public async Task<IActionResult> Create(StudentFormViewModel model)
        {
            var entity = new Student
            {
                Id = model.Id,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                ContactDetails = model.ContactDetails,
                Email = model.Email,
                PersonalId = model.PersonalId,
                DateOfBirth = model.DateOfBirth
            };

            return RedirectToAction(nameof(Index));
        }
    }
}
