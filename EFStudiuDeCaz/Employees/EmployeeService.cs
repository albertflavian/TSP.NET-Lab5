using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStudiuDeCaz.Employees
{
    public class EmployeeService
    {
        private readonly EmployeeContext context;
        public EmployeeService(EmployeeContext context)
        {
            this.context = context;
        }

        public void Init()
        {
            var fte = new FullTimeEmployee
            {
                FirstName = "Jane",
                LastName =
"Doe",
                Salary = 71500M
            };
            context.Employees.Add(fte);
            fte = new FullTimeEmployee
            {
                FirstName = "John",
                LastName = "Smith",
                Salary = 62500M
            };
            context.Employees.Add(fte);
            var hourly = new HourlyEmployee
            {
                FirstName = "Tom",
                LastName =
            "Jones",
                Wage = 8.75M
            };
            context.Employees.Add(hourly);
            context.SaveChanges();

        }

        public void PrintAll()
        {
            Console.WriteLine("--- All Employees ---");
            foreach (var emp in context.Employees)
            {
                bool fullTime = emp is HourlyEmployee ? false : true;
                Console.WriteLine("{0} {1} ({2})", emp.FirstName, emp.LastName,
                fullTime ? "Full Time" : "Hourly");
            }
            Console.WriteLine("--- Full Time ---");
            foreach (var fte in context.Employees.OfType<FullTimeEmployee>())
            {
                Console.WriteLine("{0} {1}", fte.FirstName, fte.LastName);
            }
            Console.WriteLine("--- Hourly ---");
            foreach (var hourly in context.Employees.OfType<HourlyEmployee>())
            {
                Console.WriteLine("{0} {1}", hourly.FirstName,
                hourly.LastName);
            }

        }
    }
}
