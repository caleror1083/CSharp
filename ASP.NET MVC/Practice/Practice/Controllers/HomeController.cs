// Practice MVC application
using System.Web.Mvc;

// Namespaces
namespace Practice.Controllers
	{
		// Classes
		public class HomeController : Controller
			{
				// Methods(Parameters)
				public string Index()
					{
						return "Hello from MVC App";
					}
			}
	}