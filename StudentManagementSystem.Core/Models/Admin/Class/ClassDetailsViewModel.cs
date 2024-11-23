namespace StudentManagementSystem.Core.Models.Admin.Class
{
    public class ClassDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Teacher { get; set; } = null!;
        public IEnumerable<string> Students { get; set; } = new List<string>();
    }
}
