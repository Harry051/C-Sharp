using System;
// Need using at the top to make sure it knows what Console Class is.

namespace Console_Read_and_Write
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            // Lots of different Console methods built in using the System namespace.

            Console.Write("Enter a string and press enter: ");
            string input = Console.ReadLine();
            Console.WriteLine("You have entered {0}", input);
            // Taking what we put in and firing it back out at us.

            Console.Write("Please type another string and press enter: ");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}", asciiValue);
            Console.ReadKey();
            //Reading the 1st value of the input and telling us the ASCII binary code.

        }
    }
}