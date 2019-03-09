using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverload
{
    public class Employee
    {

        private List<Employee> theEmployees = new List<Employee>();


        public void eat()
        {

        }

        public void eat(string food)
        {

        }

        public void eat(List<Employee> comapnions)
        {

        }

        public void eat(string food, List<Employee> comapnions)
        {

        }



        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }

    }
}
