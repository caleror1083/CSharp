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

		public ActionResult OnPostDisplay(int value)
		{
			return Partial("_DisplaySearchPartial", _context.Employees.Where(x => x.EmployeeId == value).ToList());
		}
    }
}