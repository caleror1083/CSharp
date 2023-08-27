using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PracticeApp.Models;

namespace PracticeApp;

internal class Program
{
  private static void Main(string[] args)
  {
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddRazorPages();

    // Set Secure attribute
    builder.Services.AddAntiforgery(options => options.Cookie.SecurePolicy = CookieSecurePolicy.Always);

    // Add Database Context
    builder.Services.AddDbContext<TestAssessContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ExemptionConnection")));

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
      app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();
    app.UseRouting();
    app.UseAuthorization();
    app.MapRazorPages();
    app.Run();
  }
}