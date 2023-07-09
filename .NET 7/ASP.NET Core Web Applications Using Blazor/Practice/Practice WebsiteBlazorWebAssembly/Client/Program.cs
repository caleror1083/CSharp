using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Practice_WebsiteBlazorWebAssembly;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Practice_WebsiteBlazorWebAssembly
	{
		public class Program
			{
				public static async Task Main(string[] args)
					{
						WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);
						builder.RootComponents.Add<App>("#app");
						builder.RootComponents.Add<HeadOutlet>("head::after");
						builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
						await builder.Build().RunAsync();
					}
			}
	}