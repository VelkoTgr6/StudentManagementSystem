﻿using Microsoft.AspNetCore.Identity;
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
            var connectionString = config.GetConnectionString("DefaultConnection") ?? 
                throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            services.AddDbContext<StudentManagementDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IRepository, Repository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddRazorPages();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services,IConfiguration config)
        {
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
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
