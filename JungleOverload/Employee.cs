using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverload
{
    public class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }

 


        // Methods 

        // Eats at a random restaurant
        public string Eat()
        {
           return $"{FirstName} is eating.";
        }

        // Eats a specific food at the offic
        public string Eat(string food)
        {
            return $"{FirstName} ate {food} at the office.";
        }

        // Eats at a random restaurant with all the first names on name list
        public void Eat(List<Employee> companions)
        {
            foreach (var employee in companions)
            {
                
                Console.WriteLine($"{employee}");
                
            }
            Console.WriteLine("this is the list of emps");
        }

        public string Eat(string food, List<Employee> comapnions)
        {
            IEnumerable<object> companions = null;
            foreach (var employee in companions)
            {
                Console.WriteLine($"{employee}");
            }
            return $"Replace with the write code here";
        }

    }
}

          


