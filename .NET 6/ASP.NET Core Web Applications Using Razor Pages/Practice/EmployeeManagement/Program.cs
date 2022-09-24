using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

// Namespaces
namespace EmployeeManagement
	{
		// Classes
		public class Program
			{
				// Methods(Parameters)
				public static void Main(string[] args)
					{
						WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);
						WebApplication? app = builder.Build();

						app.MapGet("/", () => System.Diagnostics.Process.GetCurrentProcess().ProcessName);

						app.Run();
					}
			}
	}