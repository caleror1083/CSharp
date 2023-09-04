﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using System.Runtime.Versioning;
using System.Security.Principal;
using System.Text;

namespace EmployeeManagement.Pages;

public class IndexModel : PageModel
{
    public IActionResult OnGet()
    {
        return new JsonResult(new
        {
            id = 1,
            name = "Pragim"
        });
    }
}