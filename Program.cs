using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.

            var Walmart = new Company("Walmart, Inc", 1934);

            Console.WriteLine($"{Walmart.Name} was founded in {Walmart.CreatedOn}.");

            // Create three employees
            var John = new Employee("John", "Roberts", "Digital Shopper", "12/08/2018");
            var Jenny = new Employee("Jenny", "Akers", "Digital TeamLead", "05/08/2010");
            var Lessa = new Employee("Lessa", "Echols", "Digital Coach", "06/08/2000");

            List<Employee> newEmployees = new List<Employee>() { John, Lessa, Jenny };
            Walmart.Employees = newEmployees;




            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            Walmart.ListEmployee();
        }
    }
}
