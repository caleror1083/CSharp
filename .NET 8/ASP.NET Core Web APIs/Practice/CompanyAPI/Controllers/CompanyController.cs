using CompanyAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

    [HttpPost]
    [Route("departments")]
    public async Task<ActionResult<string>> PostDepartment([FromBody] Department department)
    {
        try
        {
            _context.Departments.Add(department);
            await _context.SaveChangesAsync();
            return Ok("Added Successfully!");
        }
        catch (Exception ex)
        {
            return BadRequest($"Error: {ex.Message}");
        }
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