using System.Data.Entity;

namespace EFStudiuDeCaz.Employees
{
    public class EmployeeContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
