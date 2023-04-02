using System;

namespace Constants
{
    internal class Program
    {
        //constants declared as fields and must be done OUTSIDE of main method.
        //Are unchangeable values for the lifetime of the program.
        const string birthday = "1st July 1994";
        static void Main(string[] args)
        {
            Console.WriteLine($"My Birthday is always going to be {birthday}");
            Console.ReadKey();
        }
    }
}
