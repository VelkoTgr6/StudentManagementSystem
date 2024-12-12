using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Core.Models.Admin.Student;
using System.Security.Claims;

namespace StudentManagementSystem.Controllers
{
    [Authorize(Roles = "Student,Administrator")]
    public class StudentController : Controller
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService _studentService)
        {
            studentService = _studentService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var studentId = await studentService.GetStudentIdAsync(User.GetId());
            var student = await studentService.GetHomePageAsync(studentId);
            return View(student);
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

        [HttpGet]
        public async Task<IActionResult> AllNews()
        {
            var studentId = await studentService.GetStudentIdAsync(User.GetId());
            var news = await studentService.GetAllNewsForStudentAsync(studentId);
            return View(news);
        }

        [HttpGet]
        public async Task<IActionResult> AllGrades()
        {
            var studentId = await studentService.GetStudentIdAsync(User.GetId());
            var grades = await studentService.GetAllGradesAsync(studentId);
            return View(grades);
        }

        [HttpGet]
        public async Task<IActionResult> AllRemarks()
        {
            var studentId = await studentService.GetStudentIdAsync(User.GetId());
            var remarks = await studentService.GetAllRemarksAsync(studentId);
            return View(remarks);
        }

        [HttpGet]
        public async Task<IActionResult> AllAbsences()
        {
            var studentId = await studentService.GetStudentIdAsync(User.GetId());
            var absences = await studentService.GetAllAbsencesAsync(studentId);
            return View(absences);
        }

        [HttpGet]
        public async Task<IActionResult> Schedule()
        {
            var studentId = await studentService.GetStudentIdAsync(User.GetId());
            var schedule = await studentService.GetScheduleAsync(studentId);
            return View(schedule);
        }

        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var studentId = await studentService.GetStudentIdAsync(User.GetId());
            var student = await studentService.GetStudentDetailsAsync(studentId);
            return View(student);
        }
    }
}
