using Microsoft.AspNetCore.Mvc;
using Select.Models;

namespace Select.Controllers;

public class HomeController : Controller
{
    private readonly Dictionary<string, Country> _countries;

    public HomeController()
    {
        _countries = new Dictionary<string, Country>
        {
            { "AUS", new Country { Code = "AUS", Name = "Australia", Capital = "Canberra" }},
            { "IND", new Country { Code = "IND", Name = "India", Capital = "New Delhi" }},
				    { "USA", new Country { Code = "USA", Name = "United States", Capital = "Washington D.C." }},
				    { "GBR", new Country { Code = "GBR", Name = "United Kingdom", Capital = "London" }},
				    { "CAN", new Country { Code = "CAN", Name = "Canada", Capital = "Ottawa" }}  
        };
    }

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

    public IActionResult CollectionsD()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CollectionsD(string txtCountryCode)
    {
        if (_countries.TryGetValue(txtCountryCode.ToUpper(), out var country))
        {
            return View(country);
        }
        else
        {
            ViewBag.ErrorMessage = "Country code not valid";
            return View();
        }
    }
}