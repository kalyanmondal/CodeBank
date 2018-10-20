using MVCDemo.Helper;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    [Log]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}