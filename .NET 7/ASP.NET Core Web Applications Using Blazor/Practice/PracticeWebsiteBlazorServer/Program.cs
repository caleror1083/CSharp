using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PracticeWebsiteBlazorServer.Data;

namespace PracticeWebsiteBlazorServer
	{
		public class Program
			{
				public static void Main(string[] args)
					{
						WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
						WebApplication app = builder.Build();

						// Add services to the container.
						builder.Services.AddRazorPages();
						builder.Services.AddServerSideBlazor();
						builder.Services.AddSingleton<WeatherForecastService>();

						if (!app.Environment.IsDevelopment())  // Configure the HTTP request pipeline.
							{
								app.UseExceptionHandler("/Error");
								app.UseHsts();  // The default HSTS value is 30 days.
							}
						app.UseHttpsRedirection();
						app.UseStaticFiles();
						app.UseRouting();
						app.MapBlazorHub();
						app.MapFallbackToPage("/_Host");
						app.Run();
					}
			}
	}