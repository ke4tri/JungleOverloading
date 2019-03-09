using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverload
{
    public class Restaurant
    {
        //public string newRestaurant { get; set; }
        public string RestaurantName { get; set; }

        // list of Restaurants
        public List<Restaurant> listRestaurant = new List<Restaurant>();

        //
        public Restaurant(string newName)
        {
            RestaurantName = newName;
        }

        public void addRestaurant(Restaurant restaurant)
        {
            listRestaurant.Add(restaurant);
        }

        public void removeRestaurant(Restaurant restaurant)
        {
            listRestaurant.Remove(restaurant);
        }

       
    }
}
