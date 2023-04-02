using System;

namespace Virtual_and_Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog lucysDog = new Dog("Smudge", 5);
            Console.WriteLine($"This dog is called {lucysDog.Name}, and is {lucysDog.Age} years old");
            lucysDog.Eat();
            lucysDog.MakeSound();

            Cow lucysCow = new Cow("Mathilda", 10);
            lucysCow.Play();
            lucysCow.MakeSound();
            lucysCow.Eat();

            Cow harrysCow = new Cow("Ermentrude", 1);
            harrysCow.Eat();

            Pig tomsPig = new Pig("Big Frank", 7);
            tomsPig.Play();
        }
    }
}
