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
            "Tome",
            "Jane"
        };

        //public string Name { get; set; }

        //public int Id { get; set; }

        //public List<string> Names { get; set; }

        public string randomPerson()
        {
            var Random = new Random();
            int r = Random.Next(Peoples.Count);
            return ((string)Peoples[r]);
        }


    }
}
