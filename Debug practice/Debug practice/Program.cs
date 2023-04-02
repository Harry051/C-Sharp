using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Debug_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning World!");
            Console.WriteLine("Good Afternoon World!");
            EveningTime();
            Console.WriteLine("Good Night World!");

            var names = new List<string> { "Peter", "Toby", "Jane", "Amanda" };

            foreach(string name in names)
            {
                Console.WriteLine($"Hello {name}");
            }
           
        }

        public static void EveningTime()
        {
            Console.WriteLine("Good Evening World");
        }
    }
}
