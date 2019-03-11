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
            var newPerson = new Employee(firstNameOfNewEmployee, "smith");
            var aRest = new Restaurant();
            var randomPeople = new People();
            var randomFoodFunc = new Food();

            var randomRest = aRest.RandomRestaurant();
            var personEats = newPerson.Eat();
            var randomFood = randomFoodFunc.randomFood();
            var personEatsWithPeople = newPerson.Eat();
            var thePeopleTest = randomPeople.Peoples;
            
            var randomPerson = randomPeople.randomPerson();

            Console.WriteLine(randomFood, thePeopleTest);
            Console.WriteLine(randomPerson);
            Console.WriteLine($"{personEatsWithPeople}");
            Console.WriteLine($"{personEats} They are at {randomRest}");
            
            

            
            Console.ReadLine();
        }
    }
}
    
           



        






           
            



    

