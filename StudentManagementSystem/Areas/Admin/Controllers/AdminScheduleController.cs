using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Core.Contracts.Admin;
using StudentManagementSystem.Core.Models.Admin.Schedule;

namespace StudentManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class AdminScheduleController : Controller
    {
        private readonly IAdminScheduleService scheduleService;
        private readonly IAdminCourseService adminCourseService;
        private readonly IAdminClassService adminClassService;
        private readonly ILogger<AdminScheduleController> logger;

        public AdminScheduleController(
            IAdminScheduleService _scheduleService,
            IAdminCourseService _adminCourseService,
            IAdminClassService _adminClassService,
            ILogger<AdminScheduleController> _logger)
        {
            scheduleService = _scheduleService;
            adminCourseService = _adminCourseService;
            adminClassService = _adminClassService;
            logger = _logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var schedules = await adminClassService.GetAllClassesAsync();
            return View(schedules);
        }

        [HttpGet]
        public async Task<IActionResult> ClassSchedule(int classId)
        {
            var model = await scheduleService.GetCourseSchedulesByIdAsync(classId);

            if (!model.Any())
            {
                logger.LogInformation($"No schedules found for class with ID: {classId}");
                return NotFound();
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new CourseScheduleInputModel()
            {
                Courses = await adminCourseService.GetAllCoursesAsync(),
                Classes = await adminClassService.GetAllClassesAsync()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CourseScheduleInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await scheduleService.AddCourseScheduleAsync(model);

            logger.LogInformation($"New schedule added for class ID: {model.ClassId}, course ID: {model.CourseId}");

            return RedirectToAction("Index", "AdminHome");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await scheduleService.GetCourseScheduleByIdAsync(id);

            if (model == null)
            {
                logger.LogWarning($"Schedule with ID: {id} not found for editing.");
                return NotFound();
            }

            model.Courses = await adminCourseService.GetAllCoursesAsync();
            model.Classes = await adminClassService.GetAllClassesAsync();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, CourseScheduleInputModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Courses = await adminCourseService.GetAllCoursesAsync();
                model.Classes = await adminClassService.GetAllClassesAsync();

                return View(model);
            }

            await scheduleService.EditCourseScheduleAsync(id, model);

            logger.LogInformation($"Schedule with ID: {id} has been edited.");

            return RedirectToAction(nameof(ClassSchedule), new { classId = model.ClassId });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await scheduleService.DeleteCourseScheduleAsync(id);

            logger.LogInformation($"Schedule with ID: {id} has been deleted.");

            return RedirectToAction(nameof(Index));
        }
    }
}
