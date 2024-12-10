using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Core.Contracts.Admin;
using StudentManagementSystem.Core.Models.Admin.Student;
using StudentManagementSystem.Infrastructure.Data.Models;
using static StudentManagementSystem.Core.Constants.ErrorMessageConstants;

namespace StudentManagementSystem.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminStudentController : Controller
    {
        private readonly IAdminService adminService;
        private readonly IAdminClassService adminClassService;
        private readonly IAdminCourseService adminCourseService;
        private readonly IAdminStudentService adminStudentService;

        public AdminStudentController(IAdminService _adminService,
            IAdminClassService _adminClassService,
            IAdminCourseService _adminCourseService,
            IAdminTeacherService _adminTeacherService,
            IAdminStudentService _adminStudentService,
            UserManager<IdentityUser> _userManager,
            RoleManager<IdentityRole> _roleManager)
        {
            adminService = _adminService;
            adminClassService = _adminClassService;
            adminCourseService = _adminCourseService;
            adminStudentService = _adminStudentService;
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
        public async Task<IActionResult> CreateStudent(StudentFormViewModel model, IFormFile? profilePictureFile)
        {
            var emailExists = await adminService.EmailExistAsync(model.Email);
            if (!emailExists)
            {
                ModelState.AddModelError(nameof(model.Email), InvalidEmailMessage);
            }

            var students = await adminService.GetAllAsync<Student>();

            if (students.Any(s => s.PersonalId == model.PersonalId || s.IsDeleted == false))
            {
                ModelState.AddModelError(nameof(model.PersonalId), "Student with this Personal Id already exists!");
            }

            if (!ModelState.IsValid)
            {
                model.Classes = await adminClassService.GetAllClassesAsync();
                return View(model);
            }

            var id = await adminStudentService.CreateStudentAsync(model, profilePictureFile);

            return RedirectToAction(nameof(DetailsStudent), new { id });
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
        public async Task<IActionResult> EditStudent(int id, StudentFormViewModel model, IFormFile? profilePictureFile)
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

            await adminStudentService.EditStudentAsync(id, model, profilePictureFile);

            return RedirectToAction(nameof(DetailsStudent), new { id });
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

        [HttpGet]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            if (await adminStudentService.ExistAsync(id) == false)
            {
                return BadRequest();
            }
            await adminStudentService.DeleteStudentAsync(id);
            return RedirectToAction(nameof(AllStudents));
        }

        [HttpGet]
        public async Task<IActionResult> StudentGrades(int id)
        {
            if (await adminStudentService.ExistAsync(id) == false)
            {
                return BadRequest();
            }
            var grades = await adminStudentService.GetStudentGradesAsync(id);
            ViewBag.StudentId = id;
            return View(grades);
        }

        [HttpGet]
        public async Task<IActionResult> EditGrade(int id)
        {

            var model = await adminStudentService.GetGradeFormModelByIdAsync(id);

            if (model != null)
            {
                model.Courses = await adminCourseService.GetAllCoursesAsync();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditGrade(int id, StudentGradeFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Courses = await adminCourseService.GetAllCoursesAsync();
                return View(model);
            }
            await adminStudentService.EditGradeAsync(id, model);
            return RedirectToAction(nameof(StudentGrades), new { id = model.StudentId });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteGrade(int id)
        {
            var grade = await adminStudentService.GetGradeFormModelByIdAsync(id);
            if (grade == null)
            {
                return BadRequest();
            }
            await adminStudentService.DeleteGradeAsync(id);
            return RedirectToAction(nameof(StudentGrades), new { id = grade.StudentId });
        }

        [HttpGet]
        public async Task<IActionResult> StudentRemarks(int id)
        {
            if (await adminStudentService.ExistAsync(id) == false)
            {
                return BadRequest();
            }
            var remarks = await adminStudentService.GetStudentRemarksAsync(id);
            ViewBag.StudentId = id;
            return View(remarks);
        }

        [HttpGet]
        public async Task<IActionResult> EditRemark(int id)
        {
            var model = await adminStudentService.GetRemarkFormModelByIdAsync(id);

            if (model != null)
            {
                model.Courses = await adminCourseService.GetAllCoursesAsync();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRemark(int id, StudentRemarkFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Courses = await adminCourseService.GetAllCoursesAsync();
                return View(model);
            }
            await adminStudentService.EditRemarkAsync(id, model);
            return RedirectToAction(nameof(StudentRemarks), new { id = model.StudentId });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteRemark(int id)
        {
            var remark = await adminStudentService.GetRemarkFormModelByIdAsync(id);
            if (remark == null)
            {
                return BadRequest();
            }
            await adminStudentService.DeleteRemarkAsync(id);
            return RedirectToAction(nameof(StudentRemarks), new { id = remark.StudentId });
        }

        [HttpGet]
        public async Task<IActionResult> StudentAbsences(int id)
        {
            if (await adminStudentService.ExistAsync(id) == false)
            {
                return BadRequest();
            }
            var absences = await adminStudentService.GetStudentAbsencesAsync(id);
            ViewBag.StudentId = id;
            return View(absences);
        }

        [HttpGet]
        public async Task<IActionResult> EditAbsence(int id)
        {
            var model = await adminStudentService.GetAbsenceFormModelByIdAsync(id);
            if (model != null)
            {
                model.Courses = await adminCourseService.GetAllCoursesAsync();
                return View(model);
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditAbsence(int id, StudentAbsenceFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Courses = await adminCourseService.GetAllCoursesAsync();
                return View(model);
            }
            await adminStudentService.EditAbsenceAsync(id, model);
            return RedirectToAction(nameof(StudentAbsences), new { id = model.StudentId });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAbsence(int id)
        {
            var absence = await adminStudentService.GetAbsenceFormModelByIdAsync(id);
            if (absence == null)
            {
                return BadRequest();
            }
            await adminStudentService.DeleteAbsenceAsync(id);
            return RedirectToAction(nameof(StudentAbsences), new { id = absence.StudentId });

        }
    }
}
