using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Core.Contracts.Admin;
using StudentManagementSystem.Core.Models.Admin.Class;
using StudentManagementSystem.Core.Models.Admin.Course;
using StudentManagementSystem.Core.Models.Admin.Student;
using StudentManagementSystem.Core.Models.Admin.Teacher;
using StudentManagementSystem.Infrastructure.Data.Models;
using System.Security.Claims;
using static StudentManagementSystem.Core.Constants.ErrorMessageConstants;

namespace StudentManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService adminService;
        private readonly IAdminClassService adminClassService;
        private readonly IAdminCourseService adminCourseService;
        private readonly IAdminTeacherService adminTeacherService;
        private readonly IAdminStudentService adminStudentService;

        public AdminController(IAdminService adminService,
            IAdminClassService adminClassService,
            IAdminCourseService adminCourseService,
            IAdminTeacherService adminTeacherService,
            IAdminStudentService adminStudentService)
        {
            this.adminService = adminService;
            this.adminClassService = adminClassService;
            this.adminCourseService = adminCourseService;
            this.adminTeacherService = adminTeacherService;
            this.adminStudentService = adminStudentService;
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
                Classes = await adminClassService.GetAllClassesAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent(StudentFormViewModel model)
        {
            if (await adminService.EmailExistAsync(model.Email) == false)
            {
                ModelState.AddModelError(nameof(model.Email), InvalidEmailMessage);
            }

            if (!ModelState.IsValid)
            {
                model.Classes = await adminClassService.GetAllClassesAsync();
                return View(model);
            }

            var id = await adminStudentService.CreateStudentAsync(model);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> CreateCourse()
        {
            var model = new CourseFormViewModel()
            {
                Teachers = await adminTeacherService.GetAllTeachersAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse(CourseFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Teachers = await adminTeacherService.GetAllTeachersAsync();
                return View(model);
            }

            var publisherId = User.GetId();

            var id = await adminCourseService.CreateCourseAsync(model, publisherId);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> CreateTeacher()
        {
            var model = new TeacherFormViewModel()
            {
                AvailableCourses = await adminCourseService.GetAllCoursesAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTeacher(TeacherFormViewModel model)
        {
            if (await adminService.EmailExistAsync(model.Email) == false)
            {
                ModelState.AddModelError(nameof(model.Email), InvalidEmailMessage);
            }

            if (!ModelState.IsValid)
            {
                model.Courses = await adminCourseService.GetAllCoursesAsync();
                return View(model);
            }

            var id = await adminTeacherService.CreateTeacherAsync(model);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> CreateClass()
        {
            var model = new ClassFormViewModel()
            {
                Teachers = await adminTeacherService.GetAllTeachersAsync(),
                AvailableCourses = await adminCourseService.GetAllCoursesAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateClass(ClassFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Teachers = await adminTeacherService.GetAllTeachersAsync();
                model.AvailableCourses = await adminCourseService.GetAllCoursesAsync();
                return View(model);
            }

            var id = await adminClassService.CreateClassAsync(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> AllStudents([FromQuery] AllStudentsQueryModel query)
        {
            var students = await adminStudentService.AllAsync(
                query.Class,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                query.StudentsPerPage);

            query.Classes = await adminClassService.GetAllClassesNamesAsync();
            query.TotalStudentsCount = students.TotalStudentsCount;
            query.Students = students.Students;
            query.TotalPages = (int)Math.Ceiling(students.TotalStudentsCount / (double)query.StudentsPerPage);

            return View(query);
        }

        [HttpGet]
        public async Task<IActionResult> EditStudent(int id)
        {
            if (await adminStudentService.ExistAsync(id) == false)
            {
                return BadRequest();
            }
            
            var model = await adminStudentService.GetStudentFormModelByIdAsync(id);

            if (model != null)
            {
                model.Classes = await adminClassService.GetAllClassesAsync();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditStudent(int id, StudentFormViewModel model)
        {
            if (await adminStudentService.ExistAsync(id) == false)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                model.Classes = await adminClassService.GetAllClassesAsync();
                return View(model);
            }
            await adminStudentService.EditStudentAsync(id, model);
            return RedirectToAction(nameof(AllStudents));
        }

        [HttpGet]
        public async Task<IActionResult> DetailsStudent(int id)
        {
            if (await adminStudentService.ExistAsync(id) == false)
            {
                return BadRequest();
            }
            var student = await adminStudentService.GetStudentDetailsModelByIdAsync(id);
            return View(student);
        }

    }
}
