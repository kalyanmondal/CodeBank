using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTester
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Database.SetInitializer<EmployeeDBContext>(null);
            ////////Database.SetInitializer(new EmployeeDBContextSeeder());
            ////EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            ////List<Employee> employees = employeeDBContext.Employees.ToList();

            ////foreach(Employee e in employees)
            ////{
            ////    Console.Write("{0} --> {1} --> {2} --> {3} --> {4}", e.Id, e.FirstName, e.LastName, e.Gender, e.Salary);
            ////    Console.WriteLine();
            ////    Console.ReadLine();
            ////}

            Employee e = new Employee()
            {
                FirstName = "FN",
                LastName = "LN",
                Gender = "M",
                Salary = 10000,
                Id = 1,
                MyProperty = 1,
            };

            var settings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Include,
                TypeNameHandling = TypeNameHandling.All,
                TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Full
            };

            string a = JsonConvert.SerializeObject(e, settings);
            string b = JsonConvert.SerializeObject(e);
        }

        private class EmployeeDBContextSeeder : DropCreateDatabaseIfModelChanges<EmployeeDBContext>
        {
            protected override void Seed(EmployeeDBContext context)
            {
                Employee employee = new Employee()
                {
                    FirstName = "FN",
                    LastName = "LN",
                    Gender = "M",
                    Salary = 10000,
                    MyProperty = 500
                };

                context.Employees.Add(employee);

                base.Seed(context);
            }
        }
    }
}
