using Microsoft.AspNetCore.Builder;

// Namespaces
namespace EmployeeManagement
	{
		// Classes
		public class Program
			{
				// Methods(Parameters)
				public static void Main(string[] args)
					{
						WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
						WebApplication app = builder.Build();

						app.MapGet("/", () => "");

						app.Run();
					}
			}
	}