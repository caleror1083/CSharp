using Microsoft.AspNetCore.Mvc;
using Select.Models;

namespace Select.Controllers;

public class HomeController() : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Indexer()
    {
        Company myCompany = new();
        return View(myCompany);
    }
}