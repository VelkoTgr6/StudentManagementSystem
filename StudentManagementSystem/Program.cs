using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StudentManagementSystem.Infrastructure;
using StudentManagementSystem.Infrastructure.Services.EmailSender;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationDbContext(builder.Configuration);

builder.Services.AddApplicationServices();

builder.Services.AddApplicationIdentity(builder.Configuration);

// Configure EmailSettings with values from the configuration
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));

// Register EmailService as a singleton service
builder.Services.AddSingleton<IEmailSender>(serviceProvider =>
{
    var emailSettings = serviceProvider.GetRequiredService<IOptions<EmailSettings>>().Value;
    return new EmailService(
        emailSettings.SmtpServer,
        emailSettings.SmtpPort,
        emailSettings.SmtpUser,
        emailSettings.SmtpPass
    );
});

builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
});

var app = builder.Build();

builder.WebHost.UseUrls("http://+:10000"); // avoids issues

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseStatusCodePagesWithRedirects("/ErrorPage/{0}");
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "admin",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseAuthentication();

app.Use(async (context, next) =>
{
    if (context.User.Identity.IsAuthenticated && context.Request.Path == "/")
    {
        if (context.User.IsInRole("Administrator"))
        {
            context.Response.Redirect("Admin/AdminHome/Index");
            return;
        }
        if (context.User.IsInRole("Teacher"))
        {
            context.Response.Redirect("/Teacher/Index");
            return;
        }
        if (context.User.IsInRole("Student"))
        {
            context.Response.Redirect("/Student/Index");
            return;
        }
    }
    await next();
});

app.UseAuthorization();

app.MapRazorPages();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var logger = services.GetRequiredService<ILogger<Program>>();

    try
    {
        var context = services.GetRequiredService<StudentManagementDbContext>();
        logger.LogInformation("Starting database migration on Render...");
        context.Database.Migrate();
        logger.LogInformation("Database migration completed successfully on Render.");
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "An error occurred applying database migrations.");
    }
}

app.Run();