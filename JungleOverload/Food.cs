using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverload
{
    class Food
    {
        List<string> food = new List<string>
        {
            "Chicken",
            "Beef Tacos",
            "Loco Beefo"
        };

        public string randomFood()
        {
            var Random = new Random();
            int r = Random.Next(food.Count);
            return ((string)food[r]);
        }
    }
}
