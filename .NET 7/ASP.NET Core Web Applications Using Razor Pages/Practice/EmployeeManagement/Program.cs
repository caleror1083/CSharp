using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EmployeeManagement
	{
		public class Program
			{
				public static void Main(string[] args)
					{
						WebApplicationBuilder builder;
						WebApplication app;
						
						builder = WebApplication.CreateBuilder(args);

						// Add services to the container.
						builder.Services.AddRazorPages();

						app = builder.Build();

						// Configure the HTTP request pipeline.
						if (!app.Environment.IsDevelopment())
							{
								app.UseExceptionHandler("/Error");
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
	}