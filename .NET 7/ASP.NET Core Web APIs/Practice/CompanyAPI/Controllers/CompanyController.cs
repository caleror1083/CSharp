using CompanyAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CompanyAPI.Controllers;

// Route template: "api/company"
[ApiController]
[Route("api/[controller]")]
public class CompanyController : ControllerBase
{
    private readonly CompanyContext _context;

    public CompanyController(CompanyContext context) => _context = context;

    // Route template: "api/company/departments"
    [HttpGet]
    [Route("departments")]
    public ActionResult<IEnumerable<Department>> GetAllDepartments()
    {
        var departmentRecords = _context.Departments.ToList();
        return departmentRecords;
    }

    // Route template: "api/company/employees"
    [HttpGet]
    [Route("employees")]
    public ActionResult<IEnumerable<Employee>> GetAllEmployees()
    {
        var employeeRecords = _context.Employees.ToList();
        return employeeRecords;
    }
}