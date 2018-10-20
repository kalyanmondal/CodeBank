using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Helper;

namespace MVCDemo.Controllers
{
    [Log]
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Hello from MVC Application!";
        }
    }
}