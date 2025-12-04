using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Core.Contracts.Admin;
using StudentManagementSystem.Core.Models.Admin.Course;
using System.Security.Claims;

namespace StudentManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class AdminCourseController : Controller
    {
        private IAdminCourseService adminCourseService;
        private IAdminTeacherService adminTeacherService;
        private ILogger<AdminCourseController> logger;

        public AdminCourseController(
            IAdminCourseService _adminCourseService
            , IAdminTeacherService _adminTeacherService
            , ILogger<AdminCourseController> _logger
            )
        {
            adminCourseService = _adminCourseService;
            adminTeacherService = _adminTeacherService;
            logger = _logger;
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

            logger.LogInformation($"Administrator with ID: {publisherId} created a new course with ID: {id} .");

            return RedirectToAction(nameof(DetailsCourse), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> AllCourses([FromQuery] AllCoursesQueryModel query)
        {
            var courses = await adminCourseService.AllAsync(
                query.Teacher,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                query.CoursesPerPage);

            query.Teachers = await adminTeacherService.GetAllTeachersNamesAsync();
            query.TotalCoursesCount = courses.TotalCoursesCount;
            query.Courses = courses.Courses;
            query.TotalPages = (int)Math.Ceiling(courses.TotalCoursesCount / (double)query.CoursesPerPage);
            return View(query);
        }

        [HttpGet]
        public async Task<IActionResult> DetailsCourse(int id)
        {
            if (await adminCourseService.CourseExistAsync(id) == false)
            {
                return NotFound();
            }
            var course = await adminCourseService.GetCourseDetailsModelByIdAsync(id);
            return View(course);
        }


        [HttpGet]
        public async Task<IActionResult> EditCourse(int id)
        {
            if (await adminCourseService.CourseExistAsync(id) == false)
            {
                return NotFound();
            }

            var model = await adminCourseService.GetCourseFormModelByIdAsync(id);

            if (model != null)
            {
                model.Teachers = await adminTeacherService.GetAllTeachersAsync();
            }
            else
            {
                return BadRequest();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditCourse(int id, CourseFormViewModel model)
        {
            if (await adminCourseService.CourseExistAsync(id) == false)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                model.Teachers = await adminTeacherService.GetAllTeachersAsync();
                return View(model);
            }

            var publisherId = User.GetId();

            await adminCourseService.EditCourseAsync(id, model, publisherId);

            logger.LogInformation($"Administrator with ID: {publisherId} edited course with ID: {id} .");

            return RedirectToAction(nameof(DetailsCourse), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            if (await adminCourseService.CourseExistAsync(id) == false)
            {
                return BadRequest();
            }

            await adminCourseService.DeleteCourseAsync(id);

            logger.LogInformation($"Course with ID: {id} was deleted.");

            return RedirectToAction(nameof(AllCourses));
        }
    }
}
