using MVCDemo.Helper;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    [Log]
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult AllEmployees()
        {
            return View();
        }
    }
}