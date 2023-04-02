using System;

namespace Maths
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Looooooooooooads of Math methods (saves writing your own methods)
            //Here are a few examples

            Console.WriteLine("Your number rounded up is: " + Math.Ceiling(2.2));
            Console.WriteLine("Your number rounded down is: " + Math.Floor(6.8));

            int num1 = 12;
            int num2 = 9;

            Console.WriteLine($"Your smaller number is {Math.Min(num1, num2)}");
            Console.WriteLine($"Your bigger number is {Math.Max(num1, num2)}");

            Console.WriteLine($"3 to the power of 5 is {Math.Pow(3, 5)}");

            Console.WriteLine($"Pi is: {Math.PI}");

            Console.WriteLine($"The square root of 25 is {Math.Sqrt(25)}");

            Console.WriteLine($"Absolute means the positive version of a number ie its absolute value " +
                $"Your's is {Math.Abs(-212)}");

            Console.WriteLine($"Cosine of 1 is {Math.Cos(1)}");

        }
    }
}
