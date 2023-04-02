using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_and_Override
{
    internal class Pig : Animal
    {
        public Pig(string name, int age):base(name, age)
        {

        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Oink");
        }
        public override void Play()
        {
            Console.WriteLine($"{Name} rolls around in shit");
        }
    }
}
