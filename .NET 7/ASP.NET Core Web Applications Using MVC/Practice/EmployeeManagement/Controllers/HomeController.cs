using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.Versioning;
using System.Security.Principal;
using System.Text;

namespace EmployeeManagement.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return new JsonResult(new
        {
            id = 1,
            name = "Pragim"
        });
    }
}