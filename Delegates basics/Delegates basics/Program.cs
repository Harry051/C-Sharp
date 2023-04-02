using System;
using System.Collections.Generic;

namespace Delegates_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List of names

            List<string> names = new List<string>() { "James", "Sid", "Gary", "Layla" };


            Console.WriteLine("Names in list before removal are:");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
                        
            //caling .RemoveAll and passing a method Filter that we created
            names.RemoveAll(Filter);  // <-- Can see if hover over something called 'Predicate'. This is the delegate

            Console.WriteLine("Names in list after removal are:");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }



        }

        //A method caled filter that takes a string
        static bool Filter(string sentence)
        {
            //return whether the string contains the letter 'y'
            //The .Contains() method returns a bool that we will return as well
            return sentence.Contains('y');
        }
    }
}
