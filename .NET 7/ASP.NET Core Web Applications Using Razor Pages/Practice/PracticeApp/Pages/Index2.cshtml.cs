using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

// Namespaces
namespace PracticeApp.Pages
{
    // Classes
    // In old ASP.Net web forms this line was written as
    // public partial class WebForm1 : System.Web.UI.Page
    public class Index2Model : PageModel
    {
        // Properties
        // In old ASP.Net web forms this line was written as
        // int ClicksCount = 1;
        public int ClicksCount { get; set; } = 1;

		// Methods
        // In old ASP.Net web forms this blick was written as
        // protected void Page_Load(object sender, EventArgs e)
        // {
        //     if (!IsPostBack)
        //     {
        //         TextBox1.Text = "0";
        //     }
        // }

        public void OnGet()
        {
            if (Request.Method != "POST")
            {
                ClicksCount = 0;
            }
        }

        // In old ASP.Net Web Forms this block was written as
        // protected void Button1_Click(object sender, EventArgs e)
        // {
        //     if (ViewState["Clicks"] != null)
        //     {
        //         ClicksCount = (int)ViewState["Clicks"] + 1;
        //     }
        //
        //     TextBox1.Text = ClicksCount.ToString();
        //     ViewState["Clicks"] = ClicksCount;
        // }
        public IActionResult OnPost()
        {
            if (TempData["Clicks"] != null)
            {
                ClicksCount = (int)TempData["Clicks"] + 1;
            }
            
            TempData["Clicks"] = ClicksCount;
            return Page();
        }
    }
}