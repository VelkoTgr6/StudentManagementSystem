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
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ITeacherService, TeacherService>();

            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IAdminClassService, AdminClassService>();
            services.AddScoped<IAdminCourseService, AdminCourseService>();
            services.AddScoped<IAdminTeacherService, AdminTeacherService>();
            services.AddScoped<IAdminStudentService, AdminStudentService>();
            services.AddScoped<IAdminScheduleService, AdminScheduleService>();


            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                var databaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");
                if (string.IsNullOrEmpty(databaseUrl))
                {
                    throw new InvalidOperationException("DATABASE_URL environment variable is not set.");
                }

                var uri = new Uri(databaseUrl);
                var userInfo = uri.UserInfo.Split(':');

                var host = uri.Host;
                var port = uri.Port != -1 ? uri.Port : 5432;
                var database = uri.AbsolutePath.TrimStart('/');
                var username = userInfo[0];
                var password = userInfo.Length > 1 ? userInfo[1] : "";

                connectionString = $"Host={host};Port={port};Database={database};Username={username};Password={password};SSL Mode=Require;Trust Server Certificate=true";

                Console.WriteLine($"Using DATABASE_URL with host {host} and database {database}");
            }
            else
            {
                Console.WriteLine("Using connection string from configuration");
            }

            services.AddDbContext<StudentManagementDbContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddScoped<IRepository, Repository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddRazorPages();

            return services;
        }



        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
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
