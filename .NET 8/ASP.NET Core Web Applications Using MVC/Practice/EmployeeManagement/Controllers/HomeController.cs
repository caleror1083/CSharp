using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers;

public class HomeController : Controller
{
    private readonly IEmployeeRepository _EmployeeRepository;

    public HomeController(IEmployeeRepository employeeRepository)
    {
        _EmployeeRepository = employeeRepository;
    }

    public IActionResult Index()
    {
        var name = _EmployeeRepository.GetEmployee(1).Name;

        return Content(name);
    }

    public IActionResult Details()
    {
        var model = _EmployeeRepository.GetEmployee(1);

        return new JsonResult(model);
    }
}