using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_part_2
{
    internal class Vehicle
    {
        public float Speed { get; set; }
        public string Colour { get; set; }

        public Vehicle()
        {
            Speed = 120f;
            Colour = "Yellow";
        }

        public Vehicle(float speed, string colour)
        {
            Speed = speed;
            Colour = colour;
        }   
    }
}
