using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StudentManagementSystem.Core.Contracts.Admin;
using StudentManagementSystem.Core.Enumerations;
using StudentManagementSystem.Core.Models.Admin.Course;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Core.Services.Admin
{
    public class AdminCourseService : IAdminCourseService
    {
        private readonly IRepository repository;
        private readonly ILogger<AdminCourseService> logger;

        public AdminCourseService(IRepository _repository, ILogger<AdminCourseService> _logger)
        {
            repository = _repository;
            logger = _logger;
        }

        public async Task<CourseQueryServiceModel> AllAsync(string? teacher = null, string? searchTerm = null, CourseSorting sorting = CourseSorting.Name, int currentPage = 1, int coursesPerPage = 10)
        {
            var courseQuery = repository.AllAsReadOnly<Course>().Where(s => s.IsDeleted == false);

            
            if (!string.IsNullOrWhiteSpace(teacher))
            {
                string[] teacherNameArr = teacher.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                courseQuery = courseQuery
                    .Where(s => s.Teacher.Titles == teacherNameArr[0] &&
                    s.Teacher.FirstName == teacherNameArr[1] &&
                    s.Teacher.LastName == teacherNameArr[2] &&
                    s.IsDeleted == false
                );
            }

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                courseQuery = courseQuery
                    .Where(t => t.Name.ToLower().Contains(searchTerm.ToLower()) ||
                                t.Teacher.FirstName.ToLower().Contains(searchTerm.ToLower()) ||
                                t.Teacher.LastName.ToLower().Contains(searchTerm.ToLower()));
            }

            courseQuery = sorting switch
            {
                CourseSorting.Name => courseQuery.OrderBy(t => t.Name),
                CourseSorting.Teacher => courseQuery.OrderBy(t => t.Teacher.FirstName).ThenBy(t => t.Teacher.LastName),
                _ => courseQuery.OrderBy(s => s.Name)
            };

            var courses = await courseQuery
                .Skip((currentPage - 1) * coursesPerPage)
                .Take(coursesPerPage)
                .Select(s => new CourseServiceModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    Teacher = s.Teacher.Titles + " " + s.Teacher.FirstName + " " + s.Teacher.LastName
                })
                .ToListAsync();

            var totalCoursesCount = await courseQuery.CountAsync();

            return new CourseQueryServiceModel
            {
                TotalCoursesCount = totalCoursesCount,
                Courses = courses
            };
        }

        public async Task<bool> CourseExistAsync(int id)
        {
            var courseExists = await repository.AllAsReadOnly<Course>()
                .Where(c => c.IsDeleted == false)
                .AnyAsync(c => c.Id == id);

            if (!courseExists)
            {
                throw new KeyNotFoundException($"Course with ID: {id} not found");
            }

            return courseExists;
        }

        public async Task<int> CreateCourseAsync(CourseFormViewModel model, string publisherId)
        {
            var existingCourse = await repository.AllAsReadOnly<Course>()
                .FirstOrDefaultAsync(c => c.Name.ToLower() == model.Name.ToLower() && c.IsDeleted == false);

            if (existingCourse != null)
            {
                logger.LogWarning($"Attempted to create a course with an existing name: {model.Name}");
                throw new InvalidOperationException($"Course with name '{model.Name}' already exists.");
            }

            var entity = new Course
            {
                Name = model.Name,
                Description = model.Description,
                TeacherId = model.TeacherId,
                PublisherId = publisherId
            };
            
            await repository.AddAsync(entity);
            await repository.SaveChangesAsync();

            logger.LogInformation($"Created new course with ID: {entity.Id} and Name: {entity.Name}");

            return entity.Id;
        }

        public async Task DeleteCourseAsync(int id)
        {
            var course = await repository.GetByIdAsync<Course>(id);

            if (course != null && course.IsDeleted == false)
            {
                course.IsDeleted = true;
            }
            else
            {
                logger.LogWarning($"Attempted to delete a non-existing or already deleted course with ID: {id}");
                throw new KeyNotFoundException($"Course with ID {id} not found.");
            }

            await repository.SaveChangesAsync();

            logger.LogInformation($"Deleted course with ID: {id} and Name: {course.Name}");
        }

        public async Task EditCourseAsync(int id, CourseFormViewModel model, string publisherId)
        {
            var course = await repository.GetByIdAsync<Course>(id);

            if (course != null && course.IsDeleted == false)
            {
                course.Name = model.Name;
                course.Description = model.Description;
                course.TeacherId = model.TeacherId;
                course.PublisherId = publisherId;
            }
            else
            {
                logger.LogWarning($"Attempted to edit a non-existing or deleted course with ID: {id}");
                throw new KeyNotFoundException($"Course with ID {id} not found.");
            }

            await repository.SaveChangesAsync();

            logger.LogInformation($"Edited course with ID: {id} and new Name: {course.Name}");
        }

        public async Task<IEnumerable<CourseServiceModel>> GetAllCoursesAsync()
        {
            var courses = await repository.AllAsReadOnly<Course>()
               .Where(c => c.IsDeleted == false)
               .Select(c => new CourseServiceModel
               {
                   Id = c.Id,
                   Name = c.Name
               })
               .ToListAsync();

            if (!courses.Any())
            {
                throw new InvalidOperationException("No courses available.");
            }

            return courses;
        }

        public async Task<IEnumerable<string>> GetAllCoursesNamesAsync()
        {
            var coursesNames = await repository.AllAsReadOnly<Course>()
                .Where(c => c.IsDeleted == false)
                .OrderBy(c => c.Name)
                .Select(c => c.Name)
                .ToListAsync();

            if (!coursesNames.Any())
            {
                throw new InvalidOperationException("No course names available.");
            }

            return coursesNames;
        }

        public async Task<CourseServiceModel> GetCourseByIdAsync(int id)
        {
            var course = await repository.GetByIdAsync<CourseServiceModel>(id);

            if (course == null)
            {
                throw new KeyNotFoundException($"Course with ID {id} not found.");
            }

            return course;
        }

        public async Task<CourseDetailsViewModel> GetCourseDetailsModelByIdAsync(int id)
        {
            var course = await repository.AllAsReadOnly<Course>()
                 .Where(s => s.Id == id && s.IsDeleted == false)
                 .Select(s => new CourseDetailsViewModel()
                 {
                     Id = s.Id,
                     Teacher = s.Teacher.Titles + " " + s.Teacher.FirstName + " " + s.Teacher.LastName,
                     Name = s.Name,
                     Description = s.Description
                 })
                 .FirstOrDefaultAsync();

            if (course == null)
            {
                throw new KeyNotFoundException($"Course with ID {id} not found.");
            }

            return course;
        }

        public async Task<CourseFormViewModel> GetCourseFormModelByIdAsync(int id)
        {
            var course = await repository.AllAsReadOnly<Course>()
                .Where(s => s.Id == id && s.IsDeleted == false)
                .Select(s => new CourseFormViewModel
                {
                    Name = s.Name,
                    Description = s.Description,
                    TeacherId = s.TeacherId ?? 0 
                })
                .FirstOrDefaultAsync();

            if (course == null)
            {
                throw new KeyNotFoundException($"Course with ID {id} not found.");
            }

            return course;
        }
    }
}
