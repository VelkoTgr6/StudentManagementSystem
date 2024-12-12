using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Core.Contracts.Admin;
using StudentManagementSystem.Core.Models.Admin.Schedule;

namespace StudentManagementSystem.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminScheduleController : Controller
    {
        private readonly IAdminScheduleService scheduleService;
        private readonly IAdminCourseService adminCourseService;
        private readonly IAdminClassService adminClassService;

        public AdminScheduleController(
            IAdminScheduleService _scheduleService, 
            IAdminCourseService _adminCourseService,
            IAdminClassService _adminClassService)
        {
            scheduleService = _scheduleService;
            adminCourseService = _adminCourseService;
            adminClassService = _adminClassService;
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
            if (ModelState.IsValid)
            {
                await scheduleService.AddCourseScheduleAsync(model);
                return RedirectToAction("Index","AdminHome");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await scheduleService.GetCourseScheduleByIdAsync(id);

            model.Courses = await adminCourseService.GetAllCoursesAsync();
            model.Classes = await adminClassService.GetAllClassesAsync();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, CourseScheduleInputModel model)
        {
            if (ModelState.IsValid)
            {
                await scheduleService.EditCourseScheduleAsync(id, model);
                return RedirectToAction(nameof(ClassSchedule), new { classId = model.ClassId });
            }
            model.Courses = await adminCourseService.GetAllCoursesAsync();
            model.Classes = await adminClassService.GetAllClassesAsync();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await scheduleService.DeleteCourseScheduleAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
