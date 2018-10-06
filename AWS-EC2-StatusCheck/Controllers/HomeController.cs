using Amazon.EC2.Model;
using AWS_EC2_StatusCheck.Helper;
using AWS_EC2_StatusCheck.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AWS_EC2_StatusCheck.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            StatusCheck statusCheck = new StatusCheck();

            List<InstanceDetails> instanceDetails = new List<InstanceDetails>();

            instanceDetails.Add(statusCheck.StatusCheckDetails("i-0602ddcf7c609a564"));

            return View(instanceDetails);
        }

        public ActionResult Terminate()
        {
            StatusCheck statusCheck = new StatusCheck();

            statusCheck.Terminate("i-05f5bb881b0df3c15");

            return new EmptyResult();
        }
    }
}