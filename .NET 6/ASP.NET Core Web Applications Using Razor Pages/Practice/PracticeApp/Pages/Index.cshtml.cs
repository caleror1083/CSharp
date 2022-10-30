using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PracticeApp.Models;

// Namespaces
namespace PracticeApp.Pages
{
	// Classes
    public class IndexModel : PageModel
    {
		// Fields
        private readonly CompanyContext _context;

		// Properties
        public IList<Employee> Employee { get; set; } = default!;

		// Constructors(Parameters)
        public IndexModel(CompanyContext context) { _context = context; }

		// Methods(Parameters)
        public async Task OnGetAsync()
        {
            if (_context.Employees != null)
            {
                Employee = await _context.Employees.ToListAsync();
            }
        }

		public ActionResult Sub(int value)
		{
			return Partial("Search", _context.Employees.Where(x => x.EmployeeId == value).ToList());
		}
    }
}
