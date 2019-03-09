using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverload
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name? ");
            var firstNameOfNewEmployee = Console.ReadLine();
            //var nameOfNewEmployee = new Employee(lineCapture);
            var newPerson = new Employee(firstNameOfNewEmployee, "smith");
            var aRest = new Restaurant();
            var randomRest = aRest.randomRestaurant();
            var personEats = newPerson.Eat();
            Console.WriteLine($"{personEats} They are at {randomRest}");
            Console.WriteLine(firstNameOfNewEmployee);



            //var newRest = new Restaurant("New Restaurant");
            //var mcdonalds = new Restaurant("Old Restaurant");
            //var hardies = new Restaurant("Good Restaurant");
            // newRest.addRestaurant(newRest);
            //newRest.listRestaurant.Add(newRest);
            //newRest.listRestaurant.Add(mcdonalds);
            //newRest.listRestaurant.Add(hardies);
            //Console.WriteLine("Add 4 restaurants : ");

            Console.ReadLine();
           
        }
    }
    
}





           
            



    

