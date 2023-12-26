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

        Response.WriteAsync($"Current employees are");
        Response.WriteAsync($"<br />");
        Response.WriteAsync($"Name of employee with ID 2: {myCompany[2]}");
				Response.WriteAsync($"<br />");
				Response.WriteAsync($"Name of employee with ID 5: {myCompany[5]}");
				Response.WriteAsync($"<br />");
				Response.WriteAsync($"Name of employee with ID 8: {myCompany[8]}");
				Response.WriteAsync($"<br />");
				Response.WriteAsync($"<br />");

				Response.WriteAsync($"Changing names of employees with ID of 2, 5, & 8");
				Response.WriteAsync($"<br />");
        myCompany[2] = $"Rob";
        myCompany[5] = $"Lance";
				myCompany[8] = $"Dean";
				Response.WriteAsync($"Name of employee with ID 2: {myCompany[2]}");
				Response.WriteAsync($"<br />");
				Response.WriteAsync($"Name of employee with ID 5: {myCompany[5]}");
				Response.WriteAsync($"<br />");
				Response.WriteAsync($"Name of employee with ID 8: {myCompany[8]}");	
				Response.WriteAsync($"<br />");
				Response.WriteAsync($"<br />");

				Response.WriteAsync($"Before update current employees are");
				Response.WriteAsync($"<br />");
				Response.WriteAsync($"Total male employees: {myCompany["Male"]}");
				Response.WriteAsync($"<br />");
				Response.WriteAsync($"Total female employees: {myCompany["Female"]}");
				Response.WriteAsync($"<br />");
				Response.WriteAsync($"<br />");

				Response.WriteAsync($"After update new employees are");
				Response.WriteAsync($"<br />");
				myCompany["Male"] = "Female";						
				Response.WriteAsync($"Total male employees: {myCompany["Male"]}");
				Response.WriteAsync($"<br />");
				Response.WriteAsync($"Total female employees: {myCompany["Female"]}");
        return View();
    }
}