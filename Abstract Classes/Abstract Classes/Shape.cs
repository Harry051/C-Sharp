using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    abstract class Shape    
    {
        public string Name { get; set; }

        public virtual void GetDims (int length, int height)
        {
            Console.WriteLine($"{Name} is {length} by {height} centimetres");
        }

        public abstract double GetVolume();
    }
}
