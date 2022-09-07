// Robert Calero - ASP.NET MVC Web Application
using System.Collections.Generic;
using System.Web.Mvc;    // Namespace declaration

// Namespaces
namespace Project.Controllers
    {
        // Classes
        public class HomeController : Controller
            {
                // Fields
                // Properties
                // Constructors(Parameters)

                // Methods(Parameters)
                public ActionResult Index()
                    {
                        ViewData["Countries"] = new List<string>()
                            {
                                "India", "US", "UK", "Canada"
                            };
                        return View();
                    }
            }
    }