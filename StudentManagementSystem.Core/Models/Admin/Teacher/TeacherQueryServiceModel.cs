using StudentManagementSystem.Core.Models.Admin.Student;

namespace StudentManagementSystem.Core.Models.Admin.Teacher
{
    public class TeacherQueryServiceModel
    {
        public IEnumerable<TeacherServiceModel> Teachers { get; set; } = new List<TeacherServiceModel>();
        public int TotalTeachersCount { get; set; }
    }
}
