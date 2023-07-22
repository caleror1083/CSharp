using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PracticeApp.Pages;

public class Index4Model : PageModel
{
    [BindProperty] public string TextBox1 { get; set; }

    public void OnGet() {}
}