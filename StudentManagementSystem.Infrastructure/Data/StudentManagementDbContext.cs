using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Infrastructure.Data.Configuration;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Infrastructure
{
    public class StudentManagementDbContext : IdentityDbContext
    {
        public StudentManagementDbContext(DbContextOptions<StudentManagementDbContext> options) 
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new StudentConfiguration());
            builder.ApplyConfiguration(new TeacherConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentsCourses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        
    }
}
