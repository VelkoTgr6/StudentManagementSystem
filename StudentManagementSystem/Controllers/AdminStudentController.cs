using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Core.Contracts.Admin;
using StudentManagementSystem.Core.Models.Admin.Class;
using StudentManagementSystem.Core.Models.Admin.Course;
using StudentManagementSystem.Core.Models.Admin.Student;
using StudentManagementSystem.Core.Models.Admin.Teacher;
using StudentManagementSystem.Core.Models.Teacher;
using StudentManagementSystem.Infrastructure.Data.Models;
using StudentManagementSystem.Models;
using System.Security.Claims;
using static StudentManagementSystem.Core.Constants.ErrorMessageConstants;

namespace StudentManagementSystem.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminStudentController : Controller
    {
        private readonly IAdminService adminService;
        private readonly IAdminClassService adminClassService;
        private readonly IAdminCourseService adminCourseService;
        private readonly IAdminTeacherService adminTeacherService;
        private readonly IAdminStudentService adminStudentService;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;

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
            adminTeacherService = _adminTeacherService;
            adminStudentService = _adminStudentService;
            userManager = _userManager;
            roleManager = _roleManager;
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

            return RedirectToAction(nameof(DetailsCourse), new {id});
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
                model.Courses = await adminCourseService.GetAllCoursesAsync();
                return View(model);
            }

            var id = await adminTeacherService.CreateTeacherAsync(model,profilePictureFile);

            return RedirectToAction(nameof(DetailsTeacher), new { id });
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
            return RedirectToAction(nameof(DetailsClass), new { id });
        }
        [HttpPost]
        public async Task<IActionResult> CreateStudent(StudentFormViewModel model, IFormFile? profilePictureFile)
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
        public async Task<IActionResult> AllTeachers([FromQuery]AllTeachersQueryModel query)
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

            await adminTeacherService.EditTeacherAsync(id, model,profilePictureFile);

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

        [HttpGet]
        public async Task<IActionResult> AllCourses([FromQuery] AllCoursesQueryModel query)
        {
            var courses= await adminCourseService.AllAsync(
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
                return BadRequest();
            }
            var course = await adminCourseService.GetCourseDetailsModelByIdAsync(id);
            return View(course);
        }


        [HttpGet]
        public async Task<IActionResult> EditCourse(int id)
        {
            if (await adminCourseService.CourseExistAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await adminCourseService.GetCourseFormModelByIdAsync(id);

            if (model != null)
            {
                model.Teachers = await adminTeacherService.GetAllTeachersAsync();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditCourse(int id, CourseFormViewModel model)
        {
            if (await adminCourseService.CourseExistAsync(id) == false)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                model.Teachers = await adminTeacherService.GetAllTeachersAsync();
                return View(model);
            }

            var publisherId = User.GetId();

            await adminCourseService.EditCourseAsync(id, model, publisherId);

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

            return RedirectToAction(nameof(AllCourses));
        }

        [HttpGet]
        public async Task<IActionResult> AllClasses([FromQuery]AllClassesQueryModel query)
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
                return BadRequest();
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
                model.Teachers = await adminTeacherService.GetAllTeachersAsync();
                model.AvailableCourses = await adminCourseService.GetAllCoursesAsync();
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
                model.Teachers = await adminTeacherService.GetAllTeachersAsync();
                model.AvailableCourses = await adminCourseService.GetAllCoursesAsync();
                return View(model);
            }
            await adminClassService.EditClassAsync(id, model);
            return RedirectToAction(nameof(DetailsClass), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> DeleteClass(int id)
        {
            if (await adminClassService.ClassExistAsync(id) == false)
            {
                return BadRequest();
            }
            await adminClassService.DeleteClassAsync(id);
            return RedirectToAction(nameof(AllClasses));
        }

        [HttpGet]
        public async Task<IActionResult> CreateRole()
        {
            var model = new RoleFormViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (await roleManager.RoleExistsAsync(model.RoleName))
            {
                ModelState.AddModelError(string.Empty, "Role already exists.");
                return View(model);
            }

            var role = new IdentityRole(model.RoleName);
            var result = await roleManager.CreateAsync(role);

            if (result.Succeeded)
            {
                return RedirectToAction(nameof(Index));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }


            return View(model);
        }

        public async Task<IActionResult> DeleteRole(string roleName)
        {
            var role = await roleManager.FindByNameAsync(roleName);
            if (role != null)
            {
                await roleManager.DeleteAsync(role);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> AddUserToRole()
        {
            var model = new UserRoleFormViewModel();

            var users = model.Users = userManager.Users.
                    Select(u => u.UserName)
                    .OrderBy(u => u)
                    .ToList();

            var roles = model.Roles = roleManager.Roles
                 .Select(r => r.Name)
                 .OrderBy(r => r)
                 .ToList();

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> AddUserToRole(UserRoleFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
               var users = model.Users = userManager.Users.
                    Select(u=>u.UserName)
                    .OrderBy(u => u)
                    .ToList();

               var roles = model.Roles = roleManager.Roles
                    .Select(r=>r.Name)
                    .OrderBy(r => r)
                    .ToList();

                return View(model);
            }

            if (await roleManager.RoleExistsAsync(model.RoleName))
            {
                var user = await userManager.FindByNameAsync(model.UserName);

                if (user != null)
                {
                    if (await userManager.IsInRoleAsync(user, model.RoleName))
                    {
                        return BadRequest();
                    }

                    await userManager.AddToRoleAsync(user, model.RoleName);
                    return RedirectToAction(nameof(Index));
                }
            }
            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> EditRole()
        {
            var model = new EditRoleViewModel
            {
                Roles = roleManager.Roles
                    .Select(r => r.Name)
                    .OrderBy(r => r)
                    .ToList()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Roles = roleManager.Roles
                    .Select(r => r.Name)
                    .OrderBy(r => r)
                    .ToList();

                return View(model);
            }

            // Find the role using its original name
            var selectedRole = await roleManager.FindByNameAsync(model.SelectedRoleName);

            if (selectedRole == null)
            {
                ModelState.AddModelError("", "The selected role does not exist.");

                model.Roles = roleManager.Roles
                    .Select(r => r.Name)
                    .OrderBy(r => r)
                    .ToList();

                return View(model);
            }

            // Update the role's name
            selectedRole.Name = model.NewRoleName;
            selectedRole.NormalizedName = model.NewRoleName.ToUpperInvariant();

            var result = await roleManager.UpdateAsync(selectedRole);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                model.Roles = roleManager.Roles
                    .Select(r => r.Name)
                    .OrderBy(r => r)
                    .ToList();

                return View(model);
            }

            // Redirect to index or a confirmation page
            return RedirectToAction(nameof(Index));
        }



        [HttpGet]
        public async Task<IActionResult> RemoveUserFromRole()
        {
            var model = new UserRoleFormViewModel();

            var users = model.Users = userManager.Users.
                    Select(u => u.UserName)
                    .OrderBy(u => u)
                    .ToList();

            var roles = model.Roles = roleManager.Roles
                 .Select(r => r.Name)
                 .OrderBy(r => r)
                 .ToList();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveUserFromRole(UserRoleFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var users = model.Users = userManager.Users.
                    Select(u => u.UserName)
                    .OrderBy(u => u)
                    .ToList();
                var roles = model.Roles = roleManager.Roles
                     .Select(r => r.Name)
                     .OrderBy(r => r)
                     .ToList();

                return View(model);
            }
            if (await roleManager.RoleExistsAsync(model.RoleName))
            {
                var user = await userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    if (!await userManager.IsInRoleAsync(user, model.RoleName))
                    {
                        return BadRequest();
                    }
                    await userManager.RemoveFromRoleAsync(user, model.RoleName);

                    return RedirectToAction(nameof(Index));
                }
            }
            return BadRequest();
        }
    }
}
