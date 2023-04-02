using System;

namespace Ternary_Challange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature outside?");
            string temperature = Console.ReadLine();
            try
            {
                int tempInt = int.Parse(temperature);
                string message = tempInt < 15 ? "It is too cold outside" : tempInt >= 16 && tempInt <= 28 ? "It is ok" : "It is hot here";
                Console.WriteLine(message);
            }
            catch(FormatException)
            {
                Console.WriteLine("Oh dear, it seems you've not entered a number. Please try again");
            }
            finally
            {
                Console.WriteLine("Thanks for using this program :)");
            }
            Console.Read();
        }
    }
}
