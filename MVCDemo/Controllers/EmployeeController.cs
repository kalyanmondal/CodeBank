using MVCDemo.Helper;
using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Mvc;
using Newtonsoft.Json;

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

        // GET: Employee
        public ActionResult AllEmployeesUsingHttpClient()
        {
            IEnumerable<Employee> Employees = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:6120/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Employee");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    
                    Employees = JsonConvert.DeserializeObject<List<Employee>>(readTask.Result);
                }
                else
                {
                    Employees = Enumerable.Empty<Employee>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(Employees);
        }

        ////[HttpPost]
        public ActionResult CreateEmployeesUsingHttpClient(Employee employee)
        {
            if (employee.Id != 0)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:6120/api/");

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync<Employee>("Employee", employee);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("AllEmployeesUsingHttpClient");
                    }
                }

                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

                return View(employee);
            }
            else
            {
                return View();
            }
        }
    }
}