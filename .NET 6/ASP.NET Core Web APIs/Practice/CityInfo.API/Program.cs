using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CityInfo.API
	{
		public class Program
			{
				public static void Main(string[] args)
					{
						WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);  // web application needs to be hosted by using a WebApplication builder which is what results from invoking CreateBuilder method

						builder.Services.AddControllers();  // once we have a builder, the Services collection on that builder can have services added via the built-in dependency injection container

						WebApplication? app = builder.Build(); // once all services are registered and configured, the web application can be built

						app.UseHttpsRedirection();  // instances of classes that implement IApplicationBuilder provide the mechanisms to configure an applications request pipeline
						app.UseAuthorization();  // configure the HTTP request pipeline to specify the middleware of how an ASP.NET Core application will respond to individual HTTP requests
						app.MapControllers();
						app.Run();
					}
			}
	}