using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeApp.Models;
using System.Linq;

namespace PracticeApp.Pages
{
    public class IndexModel : PageModel
    {
        public CompanyContext _context;

        public IndexModel(CompanyContext context) { _context = context; }

		public PartialViewResult OnGetDisplayDepartment(int value)
		{
			return Partial("_DisplayDepartmentPartial", _context.Departments.Where(x => x.DepartmentId == value).ToList());
		}

		public PartialViewResult OnGetDisplayEmployee(string value)
		{
			return Partial("_DisplayEmployeePartial", _context.Employees.Where(x => x.DepartmentName == value).GroupBy(x => x.EmployeeName).Select(x => x.First()).ToList());
		}
    }
}