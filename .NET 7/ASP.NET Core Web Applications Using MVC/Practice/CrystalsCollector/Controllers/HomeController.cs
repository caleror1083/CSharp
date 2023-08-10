using Microsoft.AspNetCore.Mvc;

namespace CrystalsCollector.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}