using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Intro
{
    internal class M3 : BMW
    {
        public M3(int hp, string colour, string model):base(hp, colour, model)
        {

        }

        /*
        public override void ShowDetails()
        {
            Console.WriteLine($"This car is a {brand} {Model}. It has {Horsepower}HP and is {Colour}");
        }
        */

        //This code will show an error message as the method has been sealed in the BMW parent class.
    }
}
