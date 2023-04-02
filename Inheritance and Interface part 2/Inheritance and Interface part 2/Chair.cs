using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_part_2
{
    internal class Chair : Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }
        public Chair(string colour, string material)
        {
            this.Colour = colour;
            this.Material = material;
            DestructionSound = "ChairShatter.MP3";
        }

        public void Destroy()
        {
            Console.WriteLine($"The {Colour} chair was destroyed");
            Console.WriteLine($"Playing Destruction Sound {DestructionSound}");
            Console.WriteLine("Spawning in broken chair parts");
        }
        //We can see that this destroy method is very different than the one for the car
        //Both are inherited from the IDestroyable interface and implement the Destroy() method.
        //Each can do it their own way. A pseudo way to sort of do multiple inheritance.
    }
}
