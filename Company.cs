using System;
using System.Collections.Generic;

namespace classes
{
    public class Company
    {
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created
            The constructor will set the value of the public properties
        */
        public Company(string _name, int _createdOn)
        {
            Name = _name;
            CreatedOn = _createdOn;


        }
        public string Name { get; }
        public int CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }

        public void ListEmployee()
        {
            foreach (Employee employee in Employees)
            {

                Console.WriteLine($"{employee.FullName} works for {Name} as {employee.Title} since {employee.StartDate}. ");
            }
        }
    }
}