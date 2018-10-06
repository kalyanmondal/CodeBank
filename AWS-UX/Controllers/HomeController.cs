using AWS_UX.Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AWS_UX.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult GetAllTheInstance()
        {
            EC2Helper eC2Helper = new EC2Helper();

            return View(eC2Helper.getAllTheInstance());
        }
    }
}