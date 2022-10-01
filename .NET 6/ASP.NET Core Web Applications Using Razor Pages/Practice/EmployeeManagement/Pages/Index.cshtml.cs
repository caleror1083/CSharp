using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Pages;

public class IndexModel : PageModel
	{
		[MaxLength(17)] public string ISBN { get; set; }
	}