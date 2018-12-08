using System.Data.Entity;

namespace EmployeeDataAccess
{
    public class EmployeeDBContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Users> Users { get; set; }
    }
}
