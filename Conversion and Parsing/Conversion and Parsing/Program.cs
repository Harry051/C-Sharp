using System;

namespace Conversion_and_Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit conversioin
            int num = 13784123;
            long bigNum = num;

            // Explicit conversion
            double myDouble = 13.842;
            int myInt;

            myInt = (int)myDouble;  // This is called casting  myInt will be 13 as cant store decimal points.

            // Type conversion
            string myString = myDouble.ToString(); // Uses 'ToString' method to change the double value into a string.
            Console.WriteLine(myString);

            bool isItRaining = false;
            string rainString = isItRaining.ToString();
            Console.WriteLine(rainString);

            // Parsing allows us to change strings into primitive data types
            string favouriteNumber = "51";
            int num1 = Int32.Parse(favouriteNumber);
            double faveDouble = Double.Parse(favouriteNumber);
            Console.WriteLine(num1);

        }
    }
}
