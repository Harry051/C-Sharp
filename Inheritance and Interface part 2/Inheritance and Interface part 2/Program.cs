using System;

namespace Inheritance_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Despite Car/Vehicle & Chair/Furniture classes not being related.
            //Want to make rulesets that acan apply to BOTH. This is where INTERFACES come in handy.

            Chair fancyChair = new Chair("Gold", "Gold");
            Chair vergilsChair = new Chair("White", "Plastic");

            Car ferrari = new Car(200f, "Red");

            //Add the 2 chairs to the IDestroyable list of Car class
            //Therefore when car is destroyed, the nearby chairs will be destroyed too

            ferrari.DestroyablesNearby.Add(fancyChair);
            ferrari.DestroyablesNearby.Add(vergilsChair);

            ferrari.Destroy();
        }
    }
}
