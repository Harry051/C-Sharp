using System;

namespace Declaring_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            char firstNumber = 'A';
            string alphabetCAPS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int num1;
            num1 = 51;
            double d1 = 1.2;
            float f1 = 1.2f; //float needs an 'f' on the end

            // declare and initialize variable.
            int num2 = 117;
            int sum = num1 + num2;

            //declare multiple variables
            int num3, num4, num5;

            //using concatination
            Console.WriteLine("Your first number is: " + num1 + " + " + "Your second number is: " + num2 + "The total sum is: " + sum);
            Console.Read();

            //using Interpolation
            Console.WriteLine($"Your total number is: {sum}");
            Console.Read();
           
           


        }
    }
}
