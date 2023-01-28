using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Namespaces
namespace PracticeApp.Pages
{
	// Classes
    public class IndexModel : PageModel
    {
		// Fields
		public CompanyContext _context;

		// Properties
		[BindProperty(SupportsGet = true)] public int Id { get; set; }
		[BindProperty] public string PageTitle { get; set; } = "Employee Check";
		[BindProperty, DataMember] public string Name { get; set; }
		[BindProperty, DataMember] public string Department { get; set; }

		// Constructors
		public IndexModel(CompanyContext context) { _context = context; }

		// Methods
		public PartialViewResult OnGetDisplayDepartment(int value) => Partial("_DisplayDepartmentPartial", _context.Departments.Where(x => x.DepartmentId == value).ToList());

		public PartialViewResult OnGetDisplayEmployee(string value) => Partial("_DisplayEmployeePartial", _context.Employees.Where(x => x.DepartmentName == value).GroupBy(x => x.EmployeeName).Select(x => x.First()).ToList());
    }
}