namespace StudentManagementSystem.Core.Contracts
{
    public interface IStudentService
    {
        Task<bool> ExistByIdAsync(string userId);
        Task<int> GetStudentIdAsync(string userId);
    }
}
