using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Runtime.Versioning;
using System.Security.Principal;
using System.Text;

namespace EmployeeManagement.Pages;

public class IndexModel : PageModel
{
    [SupportedOSPlatform("Windows")]
    public IActionResult OnGet()
    {
        var result = new StringBuilder();

        result.AppendLine($"{WindowsIdentity.GetCurrent().Name}");
        result.AppendLine($"Hello World!");
        result.AppendLine($"{Process.GetCurrentProcess().ProcessName}");

        return Content(result.ToString(), "text/plain");
    }
}