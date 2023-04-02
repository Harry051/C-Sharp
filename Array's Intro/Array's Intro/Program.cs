using System;

namespace Array_s_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declare and Initialize a new array            - 5 sets number of values in array
            int[] grades = new int[5];

            //assign values

            grades[0] = 12;
            grades[1] = 6;
            grades[2] = 20;
            grades[3] = 10;
            grades[4] = 18;

            Console.WriteLine($"First grade = {grades[0]}");

            // can change still aftere
            grades[0] = 11;
            Console.WriteLine($"First grade = {grades[0]}");


            //A second way to initialize
            int[] gradesOfSetA = { 19, 12, 3, 14, 10, 7, 18, 10 };

            //A third way to initialize
            int[] gradesOfSetB = new int[] { 16, 5, 8, 13 };


            // If want to see number of entries
            Console.WriteLine($"There are {gradesOfSetA.Length} results in class A");

            Console.Read();
        }
    }
}
