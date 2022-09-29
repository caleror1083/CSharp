using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace EmployeeManagement.Pages;

[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
[IgnoreAntiforgeryToken]
public class ErrorModel : PageModel
	{
		// Fields
		private readonly ILogger<ErrorModel> _logger;

		// Properties
		public string RequestId { get; set; }
		public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

		// Constructors(Parameters)
		public ErrorModel(ILogger<ErrorModel> logger)
			{
				_logger = logger;
			}

		// Methods(Parameters)
		public void OnGet()
			{
				RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
			}
	}