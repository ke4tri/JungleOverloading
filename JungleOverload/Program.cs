using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverload
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");
            var nameOfNewEmployee = Console.ReadLine();
            //var nameOfNewEmployee = new Employee(lineCapture);
            Console.WriteLine(nameOfNewEmployee);

            var newRest = new Restaurant("New Restaurant");
            var mcdonalds = new Restaurant("Old Restaurant");

           
            //Console.WriteLine("Add 4 restaurants : ");
            
            Console.ReadLine();
           
        }
    }



    

    
}
