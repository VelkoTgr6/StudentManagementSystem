using StudentManagementSystem.Core.Models.Admin.Schedule;

namespace StudentManagementSystem.Core.Contracts.Admin
{
    public interface IAdminScheduleService
    {
        Task<IEnumerable<CourseScheduleViewModel>> GetCourseSchedulesByIdAsync(int id);
        Task AddCourseScheduleAsync(CourseScheduleInputModel model);
        Task DeleteCourseScheduleAsync(int id);
        Task EditCourseScheduleAsync(int id, CourseScheduleInputModel model);
        Task<CourseScheduleInputModel> GetCourseScheduleByIdAsync(int id);
    }
}
