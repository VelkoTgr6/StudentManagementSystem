using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Core.Models.Teacher;
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
        public async Task<IActionResult> AllClasses(string userId)
        {
            userId = User.GetId();
            var classes = await teacherService.GetAllClassesByTeacher(userId);

            return View(classes);
        }

        [HttpGet]
        public async Task<IActionResult> StudentsByClass(int classId, string userId)
        {
            userId = User.GetId();
            var students = await teacherService.GetStudentsByTeacherAndClassAsync(classId, userId);
            return View(students);
        }

        [HttpGet]
        public async Task<IActionResult> StudentDetails(int studentId)
        {
            var student = await teacherService.GetStudentDetailsAsync(studentId);

            return View(student);
        }

        [HttpGet]
        public async Task<IActionResult> AddGrade(int studentId)
        {
            var model = new GradeFormModel
            {
                StudentId = studentId,
                Courses = await teacherService.GetTeacherCourses(User.GetId()),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddGrade(GradeFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Courses = await teacherService.GetTeacherCourses(User.GetId());
                return View(model);
            }
            await teacherService.AddGradeToStudent(model, model.StudentId);
            return RedirectToAction(nameof(StudentDetails), new { studentId = model.StudentId });
        }
    }
}
