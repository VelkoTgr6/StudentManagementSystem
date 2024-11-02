
using Microsoft.EntityFrameworkCore;

namespace StudentManagementSystem.Infrastructure.Data.Common
{
    public class Repository : IRepository
    {
        private readonly DbContext context;

        public Repository(StudentManagementDbContext _context)
        {
            context = _context;
        }

        private DbSet<T> DbSet<T>() where T : class
        {
            return context.Set<T>();
        }

        public async Task AddAsync<T>(T entity) where T : class
        {
             await DbSet<T>().AddAsync(entity);
        }

        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>();
        }

        public IQueryable<T> AllAsReadOnly<T>() where T : class
        {
            return DbSet<T>().AsNoTracking();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}
