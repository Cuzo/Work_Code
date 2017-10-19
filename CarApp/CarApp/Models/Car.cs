using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarApp.Models
{
    public class Car
    {
        //Using a code-first approach, we are creating a car model which
        //the entities will be structured around and then put into the 
        //database through Entity Framework.

        public int Year;
        public string Make { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public double MPG { get; set; }

    }
}
