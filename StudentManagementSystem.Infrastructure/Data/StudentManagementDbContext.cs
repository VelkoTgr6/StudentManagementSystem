using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Infrastructure.Data.Configuration;
using StudentManagementSystem.Infrastructure.Data.Models;
using System.Reflection.Emit;

namespace StudentManagementSystem.Infrastructure
{
    public class StudentManagementDbContext : IdentityDbContext
    {
        public StudentManagementDbContext(DbContextOptions<StudentManagementDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Grade>()
            //     .HasOne(g => g.Student)
            //     .WithMany(s => s.Grades)
            //     .OnDelete(DeleteBehavior.NoAction);

            //builder.Entity<StudentCourse>()
            //    .HasKey(sc => new { sc.StudentId, sc.CourseId });

            //builder.Entity<StudentCourse>()
            //    .HasOne(sc => sc.Student)
            //    .WithMany(s => s.StudentCourses) 
            //    .HasForeignKey(sc => sc.StudentId);

            //builder.Entity<StudentCourse>()
            //    .HasOne(sc => sc.Course)
            //    .WithMany(c => c.StudentCourses) 
            //    .HasForeignKey(sc => sc.CourseId);

            base.OnModelCreating(builder);

            builder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            builder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

            builder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Grade>()
                 .HasOne(g => g.Course)
                 .WithMany(c => c.Grades)
                 .HasForeignKey(g => g.CourseId)
                 .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete for courses

            builder.Entity<Grade>()
                .HasOne(g => g.Student)
                .WithMany(s => s.Grades)
                .HasForeignKey(g => g.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ApplyConfiguration(new IdentityUserConfiguration());
            builder.ApplyConfiguration(new TeacherConfiguration());
            builder.ApplyConfiguration(new CourseConfiguration());
            builder.ApplyConfiguration(new ClassConfiguration());
            builder.ApplyConfiguration(new StudentConfiguration());


            base.OnModelCreating(builder);
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentsCourses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
