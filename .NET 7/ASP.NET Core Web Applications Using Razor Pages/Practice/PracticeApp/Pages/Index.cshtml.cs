using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PracticeApp.Pages;

public class IndexModel : PageModel
{
    public int ClicksCount { get; set; }

    public void OnGet()
    {
        if (Request.Method != "POST")
        {
            ClicksCount = 0;
        }
    }

    public IActionResult OnPost()
    {
        ClicksCount++;
        return Page();
    }
}