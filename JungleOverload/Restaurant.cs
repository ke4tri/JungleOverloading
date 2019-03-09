using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverload
{
    public class Restaurant
    {
        //public string newRestaurant { get; set; }
        // public string RestaurantName { get; set; }

        // list of Restaurants
        //public List<Restaurant> listRestaurant = new List<Restaurant>();

        List<string> restaurants = new List<string>
        {
            "Citysldfkj",
            "Mcdonalds",
            "Hardies"
        };

        public string randomRestaurant()
        {
            var Random = new Random();
            int r = Random.Next(restaurants.Count);
            return ((string)restaurants[r]);
        }

        // loop over the list of restaurants



        // methods 


    }
}
