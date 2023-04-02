using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    internal class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Name = "Sphere";
            Radius = radius;
        }
        public override double GetVolume()
        {

            double result = 4 / 3 * Math.PI * (Math.Pow(Radius, 3));
            Console.WriteLine($"{Name} has a radius of {Radius}. The total volume is {result}CM3");
            return result;
        }


    }
}
