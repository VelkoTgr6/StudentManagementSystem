using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StudentManagementSystem.Core.Contracts.Admin;
using StudentManagementSystem.Core.Enumerations;
using StudentManagementSystem.Core.Models.Admin.Course;
using StudentManagementSystem.Core.Models.Admin.Teacher;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Core.Services.Admin
{
    public class AdminTeacherService : IAdminTeacherService
    {
        private readonly IRepository repository;
        private readonly ILogger<AdminTeacherService> logger;

        public AdminTeacherService(IRepository _repository,ILogger<AdminTeacherService> _logger)
        {
            repository = _repository;
            logger = _logger;
        }

        public async Task<TeacherQueryServiceModel> AllAsync(string? course = null, string? searchTerm = null, TeacherSorting sorting = TeacherSorting.Name, int currentPage = 1, int teachersPerPage = 10)
        {
            var teacherQuery = repository.AllAsReadOnly<Teacher>().Where(s => s.IsDeleted == false);

            if (!string.IsNullOrWhiteSpace(course))
            {
                teacherQuery = teacherQuery.Where(t => t.Courses.Any(c => c.Name == course && t.IsDeleted == false));
            }

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                teacherQuery = teacherQuery
                    .Where(t => t.FirstName.ToLower().Contains(searchTerm) ||
                            t.LastName.ToLower().Contains(searchTerm) ||
                            t.ContactDetails.Contains(searchTerm) ||
                            t.Email.ToLower().Contains(searchTerm) ||
                            t.Courses.Select(c => c.Name.ToLower()).Contains(searchTerm));
            }

            teacherQuery = sorting switch
            {
                TeacherSorting.Name => teacherQuery.OrderBy(t => t.FirstName).ThenBy(t => t.LastName),
                TeacherSorting.Course => teacherQuery.OrderBy(t => t.Courses.OrderBy(c => c.Name).FirstOrDefault().Name),
                _ => teacherQuery.OrderBy(s => s.FirstName).ThenBy(s => s.LastName)
            };

            var teachers = await teacherQuery
                .Skip((currentPage - 1) * teachersPerPage)
                .Take(teachersPerPage)
                .Select(s => new TeacherServiceModel
                {
                    Id = s.Id,
                    SchoolName = s.School.Name,
                    FirstName = s.FirstName,
                    Titles = s.Titles ?? string.Empty,
                    LastName = s.LastName,
                    ContactDetails = s.ContactDetails,
                    Email = s.Email,
                    Courses = s.Courses.Select(c => new CourseServiceModel
                    {
                        Id = c.Id,
                        Name = c.Name
                    })
                    .ToList()
                })
                .ToListAsync();

            var totalTeachersCount = await teacherQuery.CountAsync();

            return new TeacherQueryServiceModel
            {
                TotalTeachersCount = totalTeachersCount,
                Teachers = teachers
            };
        }

        public async Task<int> CreateTeacherAsync(TeacherFormViewModel model, IFormFile? profilePictureFile)
        {
            var userId = await repository.GetIdByEmailAsync(model.Email);

            if (userId == null)
            {
                throw new KeyNotFoundException("User with the provided email does not exist.");
            }

            string profilePicturePath = "/images/profiles/default.jpg";

            if (profilePictureFile != null)
            {
                profilePicturePath = await SaveProfilePictureAsync(profilePictureFile);
            }

            var entity = new Teacher
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                ContactDetails = model.ContactDetails,
                Titles = model.Titles,
                Email = model.Email,
                UserId = userId,
                ProfilePicturePath = profilePicturePath,
                SchoolId = 1
            };

            foreach (var courseId in model.SelectedCourseIds)
            {
                var course = await repository.GetByIdAsync<Course>(courseId);
                if (course != null)
                {
                    entity.Courses.Add(course);
                }
            }

            await repository.AddAsync(entity);
            await repository.SaveChangesAsync();

            logger.LogInformation($"New Teacher {entity.FirstName} {entity.LastName} with ID: {entity.Id} created successfully.");

            return entity.Id;
        }

        public async Task DeleteTeacherAsync(int id)
        {
            var teacher = await repository.GetByIdAsync<Teacher>(id);

            if (teacher == null)
            {
                throw new KeyNotFoundException($"Teacher with ID {id} not found.");
            }

            if (teacher != null && teacher.IsDeleted == false)
            {
                teacher.IsDeleted = true;
                var identityUser = await repository.GetIdentityUserByIdAsync(teacher.UserId);

                if (identityUser != null)
                {
                    identityUser.UserName = null;
                    identityUser.Email = null;
                    identityUser.PhoneNumber = null;
                    identityUser.EmailConfirmed = false;
                    identityUser.PhoneNumberConfirmed = false;
                    identityUser.LockoutEnabled = true;
                    identityUser.NormalizedEmail = null;
                    identityUser.NormalizedUserName = null;
                    identityUser.PasswordHash = null;
                    //identityUser.PersonalId = null;
                }
            }
            else
            {
                logger.LogWarning($"Attempted to delete a non-existing or already deleted teacher with ID: {id}.");
                throw new KeyNotFoundException($"Teacher with ID {id} not found or already deleted.");
            }

            logger.LogInformation($"Teacher with ID: {id} deleted successfully.");

            await repository.SaveChangesAsync();
        }
        private async Task<string> SaveProfilePictureAsync(IFormFile file)
        {
            var uploads = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "profiles");
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName); // Unique file name
            var filePath = Path.Combine(uploads, fileName);

            if (!Directory.Exists(uploads))
            {
                Directory.CreateDirectory(uploads);
            }

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return "/images/profiles/" + fileName; 
        }

        public async Task EditTeacherAsync(int id, TeacherFormViewModel model, IFormFile? profilePictureFile)
        {
            var teacher = await repository
                .All<Teacher>()
                .Include(t => t.Courses) 
                .FirstOrDefaultAsync(t => t.Id == id);

            if (teacher == null)
            {
                throw new KeyNotFoundException($"Teacher with ID {id} not found.");
            }

            if (teacher != null && teacher.IsDeleted == false)
            {
                teacher.FirstName = model.FirstName;
                teacher.LastName = model.LastName;
                teacher.ContactDetails = model.ContactDetails;
                teacher.Titles = model.Titles;
                teacher.Email = model.Email;

                var selectedCourseIds = model.SelectedCourseIds.ToHashSet();
                var existingCourseIds = teacher.Courses.Select(c => c.Id).ToHashSet();

                var coursesToAdd = selectedCourseIds.Except(existingCourseIds);

                var coursesToRemove = existingCourseIds.Except(selectedCourseIds);

                foreach (var courseId in coursesToAdd)
                {
                    var course = await repository.GetByIdAsync<Course>(courseId);
                    if (course != null)
                    {
                        teacher.Courses.Add(course);
                    }
                }

                foreach (var courseId in coursesToRemove)
                {
                    var courseToRemove = teacher.Courses.FirstOrDefault(c => c.Id == courseId);
                    if (courseToRemove != null)
                    {
                        teacher.Courses.Remove(courseToRemove);
                    }
                }

                if (profilePictureFile != null)
                {
                    teacher.ProfilePicturePath = await SaveProfilePictureAsync(profilePictureFile);
                }

                logger.LogInformation($"Teacher with ID: {id} edited successfully.");

                await repository.SaveChangesAsync();
            }

            else
            {
                logger.LogWarning($"Attempted to edit a non-existing or deleted teacher with ID: {id}.");
                throw new KeyNotFoundException($"Teacher with ID {id} not found or is deleted.");
            }
        }


        public Task<bool> ExistAsync(int id)
        {
            return repository.AllAsReadOnly<Teacher>().AnyAsync(t => t.Id == id && t.IsDeleted == false);
        }

        public async Task<IEnumerable<TeacherServiceModel>> GetAllTeachersAsync()
        {
            return await repository.AllAsReadOnly<Teacher>()
                .Where(t => t.IsDeleted == false)
               .Select(t => new TeacherServiceModel
               {
                   Id = t.Id,
                   FirstName = $"{t.Titles} {t.FirstName} {t.LastName}"
               })
               .ToListAsync();
        }

        public async Task<TeacherDetailsViewModel> GetTeacherDetailsModelByIdAsync(int id)
        {
            var teacher = await repository.AllAsReadOnly<Teacher>()
                .Where(s => s.Id == id && s.IsDeleted == false)
                .Select(s => new TeacherDetailsViewModel()
                {
                    Id = s.Id,
                    ProfilePicturePath = s.ProfilePicturePath,
                    SchoolName = s.School.Name,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    ContactDetails = s.ContactDetails,
                    Email = s.Email,
                    CourseId = s.Courses.Select(c => c.Id).FirstOrDefault(),
                    Courses = s.Courses
                    .Where(c => c.IsDeleted == false)
                    .Select(c => new CourseServiceModel
                    {
                        Id = c.Id,
                        Name = c.Name
                    }).ToList(),
                })
                .FirstOrDefaultAsync();

            if (teacher == null)
            {
                throw new KeyNotFoundException($"Teacher with ID: {id} not found.");
            }

            return teacher;
        }

        public async Task<TeacherFormViewModel> GetTeacherFormModelByIdAsync(int id)
        {
            var teacher = await repository.AllAsReadOnly<Teacher>()
                .Where(s => s.Id == id && s.IsDeleted == false)
                .Select(s => new TeacherFormViewModel
                {
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    ContactDetails = s.ContactDetails,
                    Titles = s.Titles,
                    Email = s.Email,
                    ProfilePicturePath = s.ProfilePicturePath,
                    SelectedCourseIds = s.Courses.Select(c => c.Id).ToList()
                })
                .FirstOrDefaultAsync();

            if (teacher == null)
            {
                throw new KeyNotFoundException($"Teacher with ID: {id} not found.");
            }

            return teacher;
        }

        public async Task<IEnumerable<string>> GetAllTeachersNamesAsync()
        {
            return await repository.AllAsReadOnly<Teacher>()
                .Where(t => t.IsDeleted == false)
                .OrderBy(t => t.FirstName)
                .Select(t => $"{t.Titles} {t.FirstName} {t.LastName}")
                .ToListAsync();
        }

        public async Task<IEnumerable<TeacherServiceModel>> GetFreeTeachersAsync()
        {
            return await repository.AllAsReadOnly<Teacher>()
                .Include(t => t.Classes)
                .Where(t => t.IsDeleted == false && !t.Classes.Any())
                .Select(t => new TeacherServiceModel
                {
                    Id = t.Id,
                    FirstName = $"{t.Titles} {t.FirstName} {t.LastName}"
                })
                .ToListAsync();
        }
    }
}
