using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_and_Override
{
    internal class Dog : Animal
    {
        public bool IsHappy { get; set; }

        //Simple constructor that allows us to 
        public Dog(string name, int age) : base(name, age)
        {
            //All dogs are happy :)
            IsHappy = true;
        }


        // OVERRIDE keyword allows us to replace the Eat() method from the parent class
        public override void Eat()
        {
            //To call the Eat method from the parent class use BASE keyword.
            base.Eat();
        }

        public override void MakeSound()
        {
            //Since every animal will make a different sound, need to change the method in the child classes.
            Console.WriteLine("Woof woof");
        }

        public override void Play()
        {
            //Can do whatever you want in the new child methods  e.g. add a conditional
            if (IsHappy == true)
            {
                base.Play();
            }
        }
    }
}
