using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    class Cube : Shape 
        //If don't use the GetVolume method will get an error as needs to be referenced.
    {
        public double Length { get; set; }
        public double Height { get; set; }

        public Cube(int length, int height)
        {
            Name = "Cube";
            this.Length = length;
            this.Height = height;   
        }

        public override double GetVolume()
        {
            return Math.Pow(Length, 3);
        }

        public override void GetDims(int length, int height)
        {
            base.GetDims(length, height);
            Console.WriteLine($"{Name} has an area of {length * height}CM2");
        }
    }
}
