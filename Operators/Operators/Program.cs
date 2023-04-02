using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // Unary operators
            num3 = -num1;
            Console.WriteLine($"num3 is {num3}");   // Just flips the number from 5 to -5

            bool isSunny = true;
            Console.WriteLine($"Is it sunny? {!isSunny}"); // The ! in front flips the value from true to false

            // Increment operators
            int num = 0;
            num++;
            Console.WriteLine(num);
            Console.WriteLine(num++);
            Console.WriteLine(num);

            // Preincrement operator
            Console.WriteLine(++num); //<-- this will increment num on this line before it's called as opposed to the next line.

            // Decrement operators
            num--;
            Console.WriteLine(num);         
            Console.WriteLine(num--);
            Console.WriteLine(num);

            // Predecrement operators
            Console.WriteLine(--num);

            // Relational and Type operators
            bool isLower;
            isLower = num1 > num2;
            Console.WriteLine(isLower);

            // Equaltiy operators
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine(isEqual);

            isEqual = num1 != num2;       // Will return true as != means NOT EQUAL
            Console.WriteLine(isEqual);

            // Conditional operators
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny; //And statement. Will print true if both statements are true.
            isLowerAndSunny = isLower || isSunny;//Or statement. Will print true if one statement is true.
        }
    }
}
