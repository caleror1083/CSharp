using Practice.Models;
using System.Web.Mvc;

// Namespaces
namespace Practice.Controllers
    {
        // Classes
        public class EmployeeController : Controller
            {
                // Methods(Parameters)
                public ActionResult Details()
                    {
                        Employee myEmployee = new Employee()
                            {
                                ID = 1,
                                Name = "John",
                                Salary = 5000,
                                Gender = "Male",
                                DepartmentID = 3
                            };
                        return View(myEmployee);
                    }
            }
    }