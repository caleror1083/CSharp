using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
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

        // Add services to the container.
        builder.Services.AddRazorPages();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        // Create a logger factory and configure it, add Eventlog logger provider
        var loggerFactory = LoggerFactory.Create(builder => { builder.AddEventLog(); });

        // Create a logger instance
        var logger = loggerFactory.CreateLogger<Program>();

        // Writes a string to the application event logbefore the application starts
        logger.LogInformation($"User trying to authenticate: {WindowsIdentity.GetCurrent().Name}");

        app.MapRazorPages();
        app.Run();
    }
}