using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_and_Override
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            IsHungry = true;

        }
        
        //The VIRTUAL keyword allows for this method to be overridden by other classes
        public virtual void MakeSound()
        {

        }

        public virtual void Eat()
        {
            if(IsHungry)
            {
                Console.WriteLine($"{Name} is hungry, give them some food!");
            }
            else
            {
                Console.WriteLine($"{Name} has already eaten recently");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}
