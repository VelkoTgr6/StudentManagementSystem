using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Core.Contracts.Admin;
using StudentManagementSystem.Core.Services;
using StudentManagementSystem.Core.Services.Admin;
using StudentManagementSystem.Infrastructure;
using StudentManagementSystem.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension 
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService,StudentService>();
            services.AddScoped<ITeacherService, TeacherService>();

            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IAdminClassService, AdminClassService>();
            services.AddScoped<IAdminCourseService, AdminCourseService>();
            services.AddScoped<IAdminTeacherService, AdminTeacherService>();
            services.AddScoped<IAdminStudentService, AdminStudentService>();
            services.AddScoped<IAdminScheduleService, AdminScheduleService>();


            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services,IConfiguration config)
        {
            // First try to get connection string from configuration
            var connectionString = config.GetConnectionString("DefaultConnection");
            
            // If not found, try Render's DATABASE_URL environment variable
            if (string.IsNullOrEmpty(connectionString))
            {
                var databaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");
                if (!string.IsNullOrEmpty(databaseUrl))
                {
                    // Parse DATABASE_URL format: postgres://user:password@host:port/database
                    var uri = new Uri(databaseUrl);
                    connectionString = $"Host={uri.Host};Port={uri.Port};Database={uri.AbsolutePath.TrimStart('/')};Username={uri.UserInfo.Split(':')[0]};Password={uri.UserInfo.Split(':')[1]};SSL Mode=Require;Trust Server Certificate=true";
                }
            }
            
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Connection string 'DefaultConnection' not found in configuration and DATABASE_URL environment variable is not set.");
            }

            services.AddDbContext<StudentManagementDbContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddScoped<IRepository, Repository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddRazorPages();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services,IConfiguration config)
        {
            services.AddIdentity<IdentityUser, IdentityRole<string>>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            })
                .AddEntityFrameworkStores<StudentManagementDbContext>()
                .AddDefaultTokenProviders();
                

            return services;
        }
    }
}
