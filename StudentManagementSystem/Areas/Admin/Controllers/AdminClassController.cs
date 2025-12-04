using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Core.Contracts.Admin;
using StudentManagementSystem.Core.Models.Admin.Class;

namespace StudentManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class AdminClassController : Controller
    {
        private readonly IAdminClassService adminClassService;
        private readonly IAdminTeacherService adminTeacherService;
        private readonly IAdminCourseService adminCourseService;
        private readonly ILogger<AdminClassController> logger;

        public AdminClassController(
            IAdminClassService _adminClassService,
            IAdminTeacherService _adminTeacherService,
            IAdminCourseService _adminCourseService,
            ILogger<AdminClassController> _logger)
        {
            adminClassService = _adminClassService;
            adminTeacherService = _adminTeacherService;
            adminCourseService = _adminCourseService;
            logger = _logger;
        }

        [HttpGet]
        public async Task<IActionResult> CreateClass()
        {
            var model = new ClassFormViewModel()
            {
                Teachers = await adminTeacherService.GetFreeTeachersAsync(),
                AvailableCourses = await adminCourseService.GetAllCoursesAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateClass(ClassFormViewModel model)
        {
            var classes = await adminClassService.GetAllClassesAsync();

            if (classes.Any(c => c.Name == model.Name))
            {
                ModelState.AddModelError(nameof(model.Name), "Class already exists.");
            }

            if (!ModelState.IsValid)
            {
                model.Teachers = await adminTeacherService.GetAllTeachersAsync();
                model.AvailableCourses = await adminCourseService.GetAllCoursesAsync();
                return View(model);
            }

            var id = await adminClassService.CreateClassAsync(model);

            logger.LogInformation($"Administrator created class {model.Name} with ID: {id} .");

            return RedirectToAction(nameof(DetailsClass), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> AllClasses([FromQuery] AllClassesQueryModel query)
        {
            var classes = await adminClassService.AllAsync(
                query.Teacher,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                query.ClassesPerPage);

            query.Teachers = await adminTeacherService.GetAllTeachersNamesAsync();
            query.TotalClassesCount = classes.TotalClassesCount;
            query.Classes = classes.Classes;
            query.TotalPages = (int)Math.Ceiling(classes.TotalClassesCount / (double)query.ClassesPerPage);
            return View(query);
        }

        [HttpGet]
        public async Task<IActionResult> DetailsClass(int id)
        {
            if (await adminClassService.ClassExistAsync(id) == false)
            {
                return NotFound();
            }
            var course = await adminClassService.GetClassDetailsModelByIdAsync(id);
            return View(course);
        }

        [HttpGet]
        public async Task<IActionResult> EditClass(int id)
        {
            if (await adminClassService.ClassExistAsync(id) == false)
            {
                return BadRequest();
            }
            var model = await adminClassService.GetClassFormModelByIdAsync(id);

            if (model != null)
            {
                model.Teachers = await adminTeacherService.GetFreeTeachersAsync();
                model.AvailableCourses = await adminCourseService.GetAllCoursesAsync();
            }
            else
            {
                return BadRequest();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditClass(int id, ClassFormViewModel model)
        {
            if (await adminClassService.ClassExistAsync(id) == false)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                model.Teachers = await adminTeacherService.GetFreeTeachersAsync();
                model.AvailableCourses = await adminCourseService.GetAllCoursesAsync();
                return View(model);
            }
            await adminClassService.EditClassAsync(id, model);

            logger.LogInformation($"Administrator edited class {model.Name} with ID: {id} .");

            return RedirectToAction(nameof(DetailsClass), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> DeleteClass(int id)
        {
            if (await adminClassService.ClassExistAsync(id) == false)
            {
                return NotFound();
            }
            await adminClassService.DeleteClassAsync(id);

            logger.LogInformation($"Administrator deleted class with ID: {id} .");

            return RedirectToAction(nameof(AllClasses));
        }
    }
}
