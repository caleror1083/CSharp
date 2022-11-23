using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeApp.Models;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

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
		public Employee CheckEmployee { get; set; }
		[BindProperty, DataMember] public string Name { get; set; }
		[BindProperty, DataMember] public string DeptName { get; set; }
		public string OutputSSN { get; set; }

		// Constructors
		public IndexModel(CompanyContext context) { _context = context; }

		// Methods
		public PartialViewResult OnGetDisplayDepartment(int value) => Partial("_DisplayDepartmentPartial", _context.Departments.Where(x => x.DepartmentId == value).ToList());
		public PartialViewResult OnGetDisplayEmployee(string value) => Partial("_DisplayEmployeePartial", _context.Employees.Where(x => x.DepartmentName == value).GroupBy(x => x.EmployeeName).Select(x => x.First()).ToList());

		public async Task<IActionResult> OnPostSubmit()
		{
			OutputSSN = $"{SubstringCheck(OutputSSN, 3)}-{SubstringCheck(OutputSSN, 3, 2)}-{SubstringCheck(OutputSSN, 5, 4)}";
			return Page();
		}

		public string SubstringCheck(string s, int length)
		{
			int len = s.Length;

			if (len > length)
			{
				len = length;
			}
			return s.Substring(0, len);
		}

		public string SubstringCheck(string s, int b, int length)
		{
			int len = s.Length;

			if (len <= b)
			{
				return s;
			}
			len -= b;

			if (len > length)
			{
				len = length;
			}
			return s.Substring(b, len);
		}
    }
}