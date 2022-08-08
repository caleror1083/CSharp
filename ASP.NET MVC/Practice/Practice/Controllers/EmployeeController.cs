using Practice.Models;
using System.Linq;
using System.Web.Mvc;

// Namespaces
namespace Practice.Controllers
    {
        // Classes
        public class EmployeeController : Controller
            {
                // Methods(Parameters)
                public ActionResult Details(int id)
                    {
                        EmployeeContext myEmployeeContext = new EmployeeContext();
                        Employee myEmployee = myEmployeeContext.Employees.Single(emp => emp.ID == id);
                        return View(myEmployee);
                    }
            }
    }