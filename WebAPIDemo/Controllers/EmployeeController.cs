using EmployeeDataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<Employee> GetEmployees()
        {
            using (EmployeeDBContext dbContext = new EmployeeDBContext())
            {
                List<Employee> employees = dbContext.Employees.ToList();

                return employees;
            }
        }
    }
}
