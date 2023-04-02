using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_part_2
{
    internal class Furniture
    {
        public string Colour { get; set; }
        public string Material { get; set; }


        public Furniture()
        {
            Colour = "White";
            Material = "Plastic";
        }

        public Furniture(string colour, string material)
        {
            Colour = colour;
            Material = material;
        }
    }
}
