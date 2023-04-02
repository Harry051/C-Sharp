using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Intro
{
    //Is a relationship     ie/ Audi is a car
    internal class Audi : Car
    {
        private string brand = "Audi";
        public string Model { get; set; }

        public Audi(int hp, string colour, string model):base(hp, colour)
        {
            this.Model = model;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"This car is a {brand} {Model}. It has {Horsepower}HP and is {Colour}");
        }

        //by using NEW keyword on method below gives PRIORITY to the new method rather than overriding it
        public new void Repair()
        {
            Console.WriteLine("Your Audi is fixed up :)");
        }
    }
}
