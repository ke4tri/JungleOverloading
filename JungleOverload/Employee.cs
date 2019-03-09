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

        public string Eat()
        {
           return $"{FirstName} is eating.";
        }

        public void Eat(string food)
        {

        }

        public void Eat(List<Employee> comapnions)
        {

        }

        public void Eat(string food, List<Employee> comapnions)
        {

        }

    }
}


