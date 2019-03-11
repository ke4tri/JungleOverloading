using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverload
{
    public class Restaurant
    {
        

        List<string> restaurants = new List<string>
        {
            "Citysldfkj",
            "Mcdonalds",
            "Hardies"
        };

        public string RandomRestaurant()
        {
            var Random = new Random();
            int r = Random.Next(restaurants.Count);
            return ((string)restaurants[r]);
        }

        


    }
}
