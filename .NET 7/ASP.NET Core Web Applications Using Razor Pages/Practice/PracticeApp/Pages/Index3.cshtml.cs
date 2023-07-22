using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace PracticeApp.Pages;

public class Index3Model : PageModel
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
            ClicksCount = Convert.ToInt32(Request.Form["ClicksCount"]) + 1;
            return Page();
        }
}