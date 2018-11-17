using System.Data.Entity;

namespace CodeTester
{
    public class EmployeeDBContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
