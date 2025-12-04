using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StudentManagementSystem.Core.Contracts.Admin;
using StudentManagementSystem.Core.Models.Admin.Schedule;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Core.Services.Admin
{
    public class AdminScheduleService : IAdminScheduleService
    {
        private readonly IRepository repository;
        private readonly ILogger<AdminScheduleService> logger;

        public AdminScheduleService(IRepository _repository, ILogger<AdminScheduleService> _logger)
        {
            repository = _repository;
            logger = _logger;
        }

        public async Task<IEnumerable<CourseScheduleViewModel>> GetCourseSchedulesByIdAsync(int id)
        {
            return await repository.AllAsReadOnly<CourseSchedule>()
                .Where(cs => cs.ClassId == id)
                .Include(cs => cs.Course)
                .Include(cs => cs.Class)
                .Select(cs => new CourseScheduleViewModel
                {
                    Id = cs.Id,
                    CourseName = cs.Course.Name,
                    ClassName = cs.Class.Name,
                    Day = cs.Day.ToString(),
                    StartTime = cs.StartTime.ToString(@"hh\:mm"),
                    EndTime = cs.EndTime.ToString(@"hh\:mm")
                })
                .ToListAsync();
        }

        public async Task AddCourseScheduleAsync(CourseScheduleInputModel model)
        {
           var existingSchedule = await repository.AllAsReadOnly<CourseSchedule>()
                .FirstOrDefaultAsync(cs =>
                    cs.ClassId == model.ClassId &&
                    cs.Day == model.Day &&
                    ((model.StartTime >= cs.StartTime && model.StartTime < cs.EndTime) ||
                     (model.EndTime > cs.StartTime && model.EndTime <= cs.EndTime) ||
                     (model.StartTime <= cs.StartTime && model.EndTime >= cs.EndTime)));

            if (existingSchedule != null)
            {
                logger.LogError("Schedule conflict detected when trying to add a new course schedule.");
                throw new InvalidOperationException("The class already has a schedule that conflicts with the specified time.");
            }

            var courseSchedule = new CourseSchedule
            {
                CourseId = model.CourseId,
                ClassId = model.ClassId,
                Day = model.Day,
                StartTime = model.StartTime,
                EndTime = model.EndTime
            };

            await repository.AddAsync(courseSchedule);

            logger.LogInformation($"Added new course schedule: {courseSchedule.Id}");

            await repository.SaveChangesAsync();
        }

        public async Task DeleteCourseScheduleAsync(int id)
        {
            var courseSchedule = await repository.GetByIdAsync<CourseSchedule>(id);

            if (courseSchedule != null)
            {
                repository.DeleteSchedule(courseSchedule);
                await repository.SaveChangesAsync();
            }
            else
            {
                logger.LogWarning($"Attempted to delete a non-existing or already deleted course schedule with ID: {id}.");
                throw new KeyNotFoundException($"Course schedule with ID: {id} not found.");
            }
        }

        public async Task EditCourseScheduleAsync(int id, CourseScheduleInputModel model)
        {
            var schedule = await repository.All<CourseSchedule>()
                .Where(s => s.Id == id)
                .FirstOrDefaultAsync();

            if (schedule != null)
            {
                schedule.CourseId = model.CourseId;
                schedule.ClassId = model.ClassId;
                schedule.Day = model.Day;
                schedule.StartTime = model.StartTime;
                schedule.EndTime = model.EndTime;
                await repository.SaveChangesAsync();
            }
            else
            {
                logger.LogWarning($"Attempted to edit a non-existing course schedule with ID: {id}.");
                throw new KeyNotFoundException($"Course schedule with ID: {id} not found.");
            }
        }

        public async Task<CourseScheduleInputModel> GetCourseScheduleByIdAsync(int id)
        {
            var courseSchedule =await repository.AllAsReadOnly<CourseSchedule>()
                .Where(cs => cs.Id == id)
                .Select(cs => new CourseScheduleInputModel
                {
                    CourseId = cs.CourseId,
                    ClassId = cs.ClassId,
                    Day = cs.Day,
                    StartTime = cs.StartTime,
                    EndTime = cs.EndTime,
                    SelectedClassId = cs.ClassId,
                    SelectedCourseId = cs.CourseId,
                    SelectedDay = cs.Day,
                })
                .FirstOrDefaultAsync();

            if (courseSchedule == null)
            {
                throw new KeyNotFoundException($"Course schedule with ID: {id} not found.");
            }

            return courseSchedule;
        }
    }
}
