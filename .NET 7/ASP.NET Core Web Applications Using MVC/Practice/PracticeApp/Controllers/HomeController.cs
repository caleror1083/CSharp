using Microsoft.AspNetCore.Mvc;

namespace PracticeApp.Controllers
{
    public class HomeController : Controller
    {
        public int ClicksCount { get; set; }

        [HttpGet]
        public IActionResult Index()
        {
            if (Request.Method != "POST")
            {
                ClicksCount = 0;
            }

            ViewBag.ClicksCount = ClicksCount;
            return View();
        }

        [HttpPost]
        public IActionResult Click()
        {
            ClicksCount++;
            return RedirectToAction(nameof(Index));
        }
    }
}