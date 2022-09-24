using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement
	{
		public class Program
			{
				public static void Main(string[] args)
					{
						WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
						WebApplication app = builder.Build();

						app.MapGet("/", () => "Hello World!");

						app.Run();
					}
			}
	}