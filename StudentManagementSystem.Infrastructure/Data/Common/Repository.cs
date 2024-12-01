using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Infrastructure.Data.Models;

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

        public void DeleteStudent(Student entity)
        {
            DbSet<Student>().Where(s => s.Id == entity.Id)
                .Select(s=>s.IsDeleted==true)
                .FirstOrDefault();
        }

        public void DeleteTeacher(Teacher entity)
        {
            DbSet<Teacher>().Where(t => t.Id == entity.Id)
                .Select(t => t.IsDeleted == true)
                .FirstOrDefault();
        }

        public void DeleteCourse(Course entity)
        {
            DbSet<Course>().Where(c => c.Id == entity.Id)
                .Select(c => c.IsDeleted == true)
                .FirstOrDefault();
        }



        public async Task<T?> GetByIdAsync<T>(object id) where T : class
        {
            return await DbSet<T>().FindAsync(id);
        }

        public async Task<bool> EmailExistAsync(string email)
        {
            return await DbSet<ApplicationUser>().Where(u => u.Email == email).AnyAsync();
        }

        public async Task<string> GetIdByEmailAsync(string email)
        {
            var user = await DbSet<ApplicationUser>().FirstOrDefaultAsync(u => u.Email == email);

            if (user?.Id == null)
            {
                throw new ArgumentException("User with the provided email does not exist.");
            }

            return user.Id;
        }

        public async Task UpdateStudentsPerformanceAllAsync()
        {
            var students = await DbSet<Student>()
                .Include(s => s.Grades)
                .Where(s => s.IsDeleted == false)
                .ToListAsync();

            foreach (var student in students)
            {
                double grades = 0;

                if (student.Grades.Any())
                {
                    foreach (var grade in student.Grades.Where(g=>g.IsDeleted == false))
                    {
                        grades += grade.GradeScore;
                    }
                    student.Performance = grades / student.Grades.Where(g => g.IsDeleted == false).Count();
                }
            }

            await context.SaveChangesAsync();
        }
    }
}
