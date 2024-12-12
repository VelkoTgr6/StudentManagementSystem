using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Core.Contracts.Admin;
using StudentManagementSystem.Core.Models.Admin.Schedule;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Core.Services.Admin
{
    public class AdminScheduleService : IAdminScheduleService
    {
        private readonly IRepository repository;

        public AdminScheduleService(IRepository _repository)
        {
            repository = _repository;
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
            var courseSchedule = new CourseSchedule
            {
                CourseId = model.CourseId,
                ClassId = model.ClassId,
                Day = model.Day,
                StartTime = model.StartTime,
                EndTime = model.EndTime
            };

            await repository.AddAsync(courseSchedule);
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
                throw new Exception("Course schedule not found");
            }

            return courseSchedule;
        }
    }
}
