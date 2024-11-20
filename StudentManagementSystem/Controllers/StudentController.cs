using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Core.Models.Admin.Student;

namespace StudentManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService _studentService)
        {
            studentService = _studentService;
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            if (id == 0) 
            { 

            }
            var model = new StudentDetailsViewModel();
            return View();
        }
    }
}
