using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManagement.Pages.Index;

public class DetailsModel : PageModel
{
    private readonly IEmployeeRepository _EmployeeRepository;

    public DetailsModel(IEmployeeRepository employeeRepository)
    {
        _EmployeeRepository = employeeRepository;
    }

    public IActionResult OnGet()
    {
        var model = _EmployeeRepository.GetEmployee(1);

        return new JsonResult(model);
    }
}