using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeApp.Models;
using System.Linq;

namespace PracticeApp.Pages;

public class IndexModel : PageModel
{
    private readonly TestAssessContext _context;

    public string PageTitle { get; set; } = "Residency Check";

    public IndexModel(TestAssessContext context)
    {
        _context = context;
    }

    // Reads all exemption application table information by property id
    public IActionResult OnGetDisplay(string value)
    {
        var exemptionApplications = _context.ExemptionApplications.Where(x => x.PropertyId == value).GroupBy(x => x.ApplicationReference).Select(x => x.First()).ToList();
        return Partial("_DisplayApplicationPartial", exemptionApplications);
    }
}