using Microsoft.Extensions.Options;
using StudentManagementSystem.Infrastructure.Services.EmailSender;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationDbContext(builder.Configuration);
builder.Services.AddApplicationIdentity(builder.Configuration);

// Configure EmailSettings with values from the configuration
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));

// Register EmailService as a singleton service
builder.Services.AddSingleton<IEmailSender>(serviceProvider =>
{
    var emailSettings = serviceProvider.GetRequiredService<IOptions<EmailSettings>>().Value;
    return new EmailSender(
        emailSettings.SmtpServer,
        emailSettings.SmtpPort,
        emailSettings.SmtpUser,
        emailSettings.SmtpPass
    );
});

builder.Services.AddControllersWithViews();

builder.Services.AddApplicationServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Custom middleware to redirect based on role
app.Use(async (context, next) =>
{
    if (context.User.Identity.IsAuthenticated && context.Request.Path == "/")
    {
        if (context.User.IsInRole("Administrator"))
        {
            context.Response.Redirect("/AdminHome/Index");
            return;
        }
    }
    await next();
});

app.MapDefaultControllerRoute();
app.MapRazorPages();

app.Run();
