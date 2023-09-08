using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManagement.Pages;

public class IndexModel : PageModel
{
    private readonly IEmployeeRepository _EmployeeRepository;

    public IndexModel(IEmployeeRepository employeeRepository)
    {
        _EmployeeRepository = employeeRepository;
    }

    public IActionResult OnGet()
    {
        var name = _EmployeeRepository.GetEmployee(1).Name;

        return Content(name);
    }
}