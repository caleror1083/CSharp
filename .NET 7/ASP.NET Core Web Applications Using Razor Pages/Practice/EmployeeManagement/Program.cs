using EmployeeManagement.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Runtime.Versioning;
using System.Security.Principal;

namespace EmployeeManagement;

public class Program
{
    [SupportedOSPlatform("Windows")]
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Create and configure a logger factory by adding Eventlog logger provider
        var loggerFactory = LoggerFactory.Create(logBuilder => { logBuilder.AddEventLog(); });

        // Create logger instance
        var logger = loggerFactory.CreateLogger<Program>();

        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        // Exception handling middleware for non-development environments
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }
        else
        {
            var exceptionPageOptions = new DeveloperExceptionPageOptions
            {
                SourceCodeLineCount = 1
            };
            app.UseDeveloperExceptionPage(exceptionPageOptions);
        }

        // Writes a string to the application event log before the application starts
        var userName = WindowsIdentity.GetCurrent().Name;
        logger.LogInformation("User trying to authenticate: {userName}", userName);
        app.MapRazorPages();
        app.Run();
    }
}