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

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await teacherService.GetStudentsByMainClassTeacherAsync(User.GetId());
            return View(model);
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
            var student = await teacherService.GetStudentDetailsAsync(studentId,User.GetId());

            return View(student);
        }

        [HttpGet]
        public async Task<IActionResult> StudentMainTeacherDetails(int studentId)
        {
            var student = await teacherService.GetMainTeacherStudentDetailsAsync(studentId);

            ViewBag.TeacherId = await teacherService.GetTeacherEntityIdByUserIdAsync(User.GetId());

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
            await teacherService.AddGradeNewsToStudentAsync(User.GetId(), model.StudentId, model.CourseId, model.GradeScore.ToString());

            return RedirectToAction(nameof(StudentDetails), new { studentId = model.StudentId });
        }

        [HttpGet]
        public async Task<IActionResult> EditGrade(int gradeId)
        {
            var model = await teacherService.GetGradeByIdAsync(gradeId);

            model.Courses = await teacherService.GetTeacherCourses(User.GetId());
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditGrade(int gradeId, GradeFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Courses = await teacherService.GetTeacherCourses(User.GetId());
                return View(model);
            }
            await teacherService.EditGradeAsync(gradeId, model);
            await teacherService.AddGradeNewsToStudentAsync(User.GetId(), model.StudentId, model.CourseId, model.GradeScore.ToString());

            return RedirectToAction(nameof(StudentDetails), new { studentId = model.StudentId });
        }

        [HttpGet]
        public async Task<IActionResult> DeleteGrade(int gradeId)
        {
            var grade = await teacherService.GetGradeByIdAsync(gradeId);

            await teacherService.DeleteGradeAsync(gradeId);

            return RedirectToAction(nameof(StudentDetails), new { studentId = grade.StudentId });
        }
        [HttpGet]
        public async Task<IActionResult> AddAbsence(int studentId)
        {
            var model = new AbsenceFormViewModel
            {
                StudentId = studentId,
                Courses = await teacherService.GetTeacherCourses(User.GetId()),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddAbsence(AbsenceFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Courses = await teacherService.GetTeacherCourses(User.GetId());
                return View(model);
            }
            await teacherService.AddAbsenceToStudentAsync(model, model.StudentId);
            await teacherService.AddAbsenceNewsToStudentAsync(User.GetId(), model.StudentId, model.CourseId);
            return RedirectToAction(nameof(StudentDetails), new { studentId = model.StudentId });

        }

        [HttpGet]
        public async Task<IActionResult> EditAbsence(int id)
        {
            var absence = await teacherService.GetAbsenceByIdAsync(id);
            absence.Courses = await teacherService.GetTeacherCourses(User.GetId());

            return View(absence);
        }

        [HttpPost]
        public async Task<IActionResult> EditAbsence(int id, AbsenceFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Courses = await teacherService.GetTeacherCourses(User.GetId());
                return View(model);
            }
            await teacherService.EditAbsenceAsync(id, model);
            await teacherService.AddAbsenceNewsToStudentAsync(User.GetId(), model.StudentId, model.CourseId);

            return RedirectToAction(nameof(StudentDetails), new { studentId = model.StudentId });
        }

        [HttpGet]
        public async Task<IActionResult> DeleteAbsence(int id)
        {
            var absence = await teacherService.GetAbsenceByIdAsync(id);
            await teacherService.DeleteAbsenceAsync(id);
            return RedirectToAction(nameof(StudentDetails), new { studentId = absence.StudentId });
        }

        [HttpGet]
        public async Task<IActionResult> AddRemark(int studentId)
        {
            var model = new RemarkFormViewModel
            {
                StudentId = studentId,
                TeacherId = await teacherService.GetTeacherEntityIdByUserIdAsync(User.GetId()),
                Courses = await teacherService.GetTeacherCourses(User.GetId()),
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddRemark(RemarkFormViewModel model)
        {
            if (await teacherService.RemarkOfStudentExists(model.StudentId, model.RemarkText, model.CourseId))
            {
                ModelState.AddModelError(nameof(model.RemarkText),
                    $"This '{model.RemarkText}' remark already exists for the current student int this course ,please try again!");
                model.Courses = await teacherService.GetTeacherCourses(User.GetId());
                return View(model);
            }

            if (!ModelState.IsValid)
            {
                model.Courses = await teacherService.GetTeacherCourses(User.GetId());
                return View(model);
            }

            await teacherService.AddRemarkToStudentAsync(model, model.StudentId);
            await teacherService.AddRemarkNewsToStudentAsync(User.GetId(), model.StudentId, model.CourseId);

            model.CourseName = await teacherService.GetCourseNameById(model.CourseId);

            return RedirectToAction(nameof(StudentDetails), new { studentId = model.StudentId });
        }

        [HttpGet]
        public async Task<IActionResult> EditRemark(int remarkId)
        {
            var remark = await teacherService.GetRemarkByIdAsync(remarkId);
            remark.Courses = await teacherService.GetTeacherCourses(User.GetId());
            return View(remark);
        }

        [HttpPost]
        public async Task<IActionResult> EditRemark(int id, RemarkFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Courses = await teacherService.GetTeacherCourses(User.GetId());
                return View(model);
            }
            await teacherService.EditRemarkASync(id, model);
            await teacherService.AddRemarkNewsToStudentAsync(User.GetId(), model.StudentId, model.CourseId);

            model.CourseName = await teacherService.GetCourseNameById(model.CourseId);
            return RedirectToAction(nameof(StudentDetails), new { studentId = model.StudentId });
        }

        [HttpGet]
        public async Task<IActionResult> DeleteRemark(int remarkId)
        {
            var remark = await teacherService.GetRemarkByIdAsync(remarkId);
            await teacherService.DeleteRemarkAsync(remarkId);
            return RedirectToAction(nameof(StudentDetails), new { studentId = remark.StudentId });
        }

        [HttpGet]
        public async Task<IActionResult> AllNews()
        {
            var model = await teacherService.GetAllNewsByTeacherIdAsync(User.GetId());

            return View(model);
        }

        [HttpGet]
        public IActionResult AddNews()
        {
            var model = new TeacherNewsFormViewModel()
            {
                TeacherId = User.GetId()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddNews(TeacherNewsFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await teacherService.AddNewsToTeacherAsync(model);
            return RedirectToAction(nameof(AllNews));
        }

        [HttpGet]
        public async Task<IActionResult> EditNews(int id)
        {
            var model = await teacherService.GetNewsByIdAsync(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditNews(int id, TeacherNewsFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await teacherService.EditNewsAsync(id, model);
            return RedirectToAction(nameof(AllNews));
        }

        [HttpGet]
        public async Task<IActionResult> DeleteNews(int id)
        {
            await teacherService.DeleteNewsAsync(id);
            return RedirectToAction(nameof(AllNews));
        }
    }
}
