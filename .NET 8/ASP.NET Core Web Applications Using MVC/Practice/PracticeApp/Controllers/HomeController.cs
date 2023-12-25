using Microsoft.AspNetCore.Mvc;

namespace PracticeApp.Controllers;

public class HomeController : Controller
{
    public int ClicksCount { get; set; }

    public void Index()
    {
        if (Request.Method != "POST")
        {
            ClicksCount = 0;
        }
    }

    [HttpPost]
    public IActionResult Click()
    {
        ClicksCount++;
        return View();
    }
}