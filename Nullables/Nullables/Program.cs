using System;

namespace Nullables
{
    internal class Program
    {
        // A nullable is a variable that can have a value or no value.

        //Nullables can be handy as allow the program to work without data/values,
        //and can add/change it later on (See bottom example)
        static void Main(string[] args)
        {
            int? num1 = null;
            //int num2 = null;   <-- This will have an error message as no ?    Can't have null value if not a nullable

            double? num3 = 200.1;
            double? num4 = new Double?();

            bool? boolValue = new bool?();

            Console.WriteLine($"Our numbers are {num1} {num3} {num4}");
            Console.WriteLine($"Our boolean is: {boolValue}.");

            //Can see there is nothing in console printed as values are NULL. ie/ non-existent


            bool? isMale = null;

            if(isMale == true)
            {
                Console.WriteLine("User is male.");
            }
            else if(isMale == false)
            {
                Console.WriteLine("User is female.");
            }
            else
            {
                Console.WriteLine("No data on user gender.");
            }


            // ?? called null coalescing operator
            // means will give value of a UNLESS a is null, then will give value of 12.
            int? a = null;
            int b = a ?? 12;           

            Console.WriteLine(b);

        }
    }
}
