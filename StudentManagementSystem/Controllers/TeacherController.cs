using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Core.Contracts;
using System.Security.Claims;

namespace StudentManagementSystem.Controllers
{
    [Authorize(Roles = "Teacher,Administrator")]
    public class TeacherController : Controller
    {
        private readonly ITeacherService teacherService;

        public TeacherController(ITeacherService _teacherService)
        {
            teacherService = _teacherService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task <IActionResult> AllClasses(string userId)
        {
            userId = User.GetId();
            var classes = await teacherService.GetAllClassesByTeacher(userId);

            return View(classes);
        }
    }
}
