namespace StudentManagementSystem.Core.Contracts.Admin
{
    public interface IStudentService
    {
        Task<bool> ExistByIdAsync(string userId);
        Task<int> GetStudentIdAsync(string userId);
    }
}
