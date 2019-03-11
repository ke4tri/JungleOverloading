using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverload
{
    class People
    {
        public List<string> Peoples { get; set; } = new List<string>
        {
            "Joe",
            "Tom",
            "Jane"
        };


        public string randomPerson()
        {
            var Random = new Random();
            int r = Random.Next(Peoples.Count);
            return ((string)Peoples[r]);
        }


    }
}
