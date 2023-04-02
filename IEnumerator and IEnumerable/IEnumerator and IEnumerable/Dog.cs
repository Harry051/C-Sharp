using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerator_and_IEnumerable
{
    internal class Dog
    {
        public string Name { get; set; }
        public bool IsNaughtyDog { get; set; }

        public Dog(string name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughtyDog = isNaughtyDog;
        }

        public void GiveTreat(int numOfTreats)
        {
            Console.WriteLine($"{Name} said WOOF WOOF, and got {numOfTreats} treats :)");
        }
        
    }
}
