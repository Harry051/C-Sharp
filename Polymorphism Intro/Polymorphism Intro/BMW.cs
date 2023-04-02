using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Intro
{
    //Is a relationship     ie/ BMW is a car
    internal class BMW : Car
    {
        private string brand = "BMW";
        public string Model { get; set; }

        public BMW(int hp, string colour, string model) : base(hp, colour)
        {
            this.Model = model;
        }

        // using SEALED keyword means that method can no longer be inherited to further child classes
        //Must be used with an override statement
        public sealed override void ShowDetails()
        {
            Console.WriteLine($"This car is a {brand} {Model}. It has {Horsepower}HP and is {Colour}");
        }
    }
}
