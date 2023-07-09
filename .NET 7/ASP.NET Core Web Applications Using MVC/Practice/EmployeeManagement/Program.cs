using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

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

						app.UseStaticFiles();
						app.Run(async (context) =>
							{
								await context.Response.WriteAsync("Hello world");
							});

						app.Run();
					}
			}
	}