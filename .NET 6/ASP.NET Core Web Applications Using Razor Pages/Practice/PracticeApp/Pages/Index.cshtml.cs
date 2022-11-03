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

		public PartialViewResult OnPostDisplayDepartment(int value)
		{
			return Partial("_DisplayDepartmentPartial", _context.Departments.Where(x => x.DepartmentId == value).ToList());
		}

		public PartialViewResult OnPostDisplayEmployee(string value)
		{
			return Partial("_DisplayEmployeePartial", _context.Employees.Where(x => x.DepartmentName == value).ToList());
		}
    }
}