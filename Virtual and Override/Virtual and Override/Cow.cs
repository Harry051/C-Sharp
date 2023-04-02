using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_and_Override
{
    internal class Cow : Animal
    {
        public bool IsBaby;
        
        
        public Cow(string name, int age):base(name, age)
        {
            if (age > 2)
            {
                IsBaby = false;
            }
            else
            {
                IsBaby = true;
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Moo");
        }

        public override void Eat()
        {
            if (IsBaby == true)
            {
                Console.WriteLine($"{Name} wants milk");
            }
            else
            {
                Console.WriteLine($"{Name} wants grass");
            }
        }
    }
}
