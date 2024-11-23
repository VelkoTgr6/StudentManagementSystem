namespace StudentManagementSystem.Core.Models.Admin.Class
{
    public class ClassQueryServiceModel
    {
        public IEnumerable<ClassServiceModel> Classes { get; set; } = new List<ClassServiceModel>();
        public int TotalClassesCount { get; set; }
    }
}
