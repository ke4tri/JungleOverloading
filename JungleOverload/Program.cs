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
            
            // each variable has its own value instead of calling the same
            // variable with the same 'random' value 
            var randomPerson = randomPeople.randomPerson();
            var randomPersonTwo = randomPeople.randomPerson();

          
            Console.WriteLine($"This is the random Food : {randomFood} and the " +
                $"People test : {randomPerson}");
            
            
            Console.WriteLine($"This is the random person string {randomPersonTwo}");
            Console.WriteLine($"This is the person eats with people {personEatsWithPeople}");
            Console.WriteLine($"{personEats} They are at {randomRest}");
            
            

            
            Console.ReadLine();
        }
    }
}
    
           



        






           
            



    

