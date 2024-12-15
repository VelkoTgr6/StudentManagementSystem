using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Core.Contracts.Admin;
using StudentManagementSystem.Core.Models.Admin.Teacher;
using static StudentManagementSystem.Core.Constants.ErrorMessageConstants;

namespace StudentManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class AdminTeacherController : Controller
    {
        private readonly IAdminTeacherService adminTeacherService;
        private readonly IAdminCourseService adminCourseService;
        private readonly IAdminService adminService;

        public AdminTeacherController(
            IAdminTeacherService adminTeacherService,
            IAdminCourseService adminCourseService,
            IAdminService adminService)
        {
            this.adminTeacherService = adminTeacherService;
            this.adminCourseService = adminCourseService;
            this.adminService = adminService;
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
        public async Task<IActionResult> CreateTeacher(TeacherFormViewModel model, IFormFile? profilePictureFile)
        {
            if (await adminService.EmailExistAsync(model.Email) == false)
            {
                ModelState.AddModelError(nameof(model.Email), InvalidEmailMessage);
            }

            if (!ModelState.IsValid)
            {
                model.AvailableCourses = await adminCourseService.GetAllCoursesAsync();
                return View(model);
            }

            var id = await adminTeacherService.CreateTeacherAsync(model, profilePictureFile);

            return RedirectToAction(nameof(DetailsTeacher), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> AllTeachers([FromQuery] AllTeachersQueryModel query)
        {
            var teachers = await adminTeacherService.AllAsync(
                query.Course,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                query.TeachersPerPage);

            query.Courses = await adminCourseService.GetAllCoursesNamesAsync();
            query.TotalTeachersCount = teachers.TotalTeachersCount;
            query.Teachers = teachers.Teachers;
            query.TotalPages = (int)Math.Ceiling(teachers.TotalTeachersCount / (double)query.TeachersPerPage);

            return View(query);
        }

        [HttpGet]
        public async Task<IActionResult> DetailsTeacher(int id)
        {
            if (await adminTeacherService.ExistAsync(id) == false)
            {
                return BadRequest();
            }
            var student = await adminTeacherService.GetTeacherDetailsModelByIdAsync(id);
            return View(student);
        }

        [HttpGet]
        public async Task<IActionResult> EditTeacher(int id)
        {
            if (await adminTeacherService.ExistAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await adminTeacherService.GetTeacherFormModelByIdAsync(id);

            if (model != null)
            {
                model.Courses = await adminCourseService.GetAllCoursesAsync();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditTeacher(int id, TeacherFormViewModel model, IFormFile? profilePictureFile)
        {
            if (await adminTeacherService.ExistAsync(id) == false)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                model.Courses = await adminCourseService.GetAllCoursesAsync();
                return View(model);
            }

            await adminTeacherService.EditTeacherAsync(id, model, profilePictureFile);

            return RedirectToAction(nameof(DetailsTeacher), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> DeleteTeacher(int id)
        {
            if (await adminTeacherService.ExistAsync(id) == false)
            {
                return BadRequest();
            }
            await adminTeacherService.DeleteTeacherAsync(id);
            return RedirectToAction(nameof(AllTeachers));
        }

    }
}
