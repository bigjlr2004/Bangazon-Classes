using System;
namespace classes
{
    public class Employee
    {
        public Employee(string _firstName, string _lastName, string _title, string _startDate)
        {
            FirstName = _firstName;
            LastName = _lastName;
            Title = _title;
            StartDate = _startDate;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string Title { get; }
        public string StartDate { get; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

    }

}