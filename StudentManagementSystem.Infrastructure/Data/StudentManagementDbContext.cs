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
            // Configure composite key for ClassCourse
            builder.Entity<ClassCourse>()
                .HasKey(cc => new { cc.ClassId, cc.CourseId });

            builder.Entity<ClassCourse>()
                .HasOne(cc => cc.Class)
                .WithMany(c => c.ClassCourses)
                .HasForeignKey(cc => cc.ClassId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ClassCourse>()
                .HasOne(cc => cc.Course)
                .WithMany(c => c.CourseClasses)
                .HasForeignKey(cc => cc.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure relationships for Grade
            builder.Entity<Grade>()
                .HasOne(g => g.Course)
                .WithMany(c => c.Grades)
                .HasForeignKey(g => g.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Grade>()
                .HasOne(g => g.Student)
                .WithMany(s => s.Grades)
                .HasForeignKey(g => g.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure relationships for Course
            builder.Entity<Course>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Course>()
                .HasOne(c => c.Publisher)
                .WithMany()
                .HasForeignKey(c => c.PublisherId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure relationships for Student
            builder.Entity<Student>()
                .HasOne(s => s.Class)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.ClassId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Student>()
                .HasOne(s => s.User)
                .WithMany()
                .HasForeignKey(s => s.UserId)
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
        public DbSet<ClassCourse> ClassCourses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
