using System;

namespace Array_as_param
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] classAGrades = { 12, 19, 7, 13, 13, 4, 16 };
            double result = AverageGrades(classAGrades);
            Console.WriteLine($"{classAGrades.Length} students sat the test. Your class average is {result}");

            //challange below
            int[] happiness = { 1, 10, 100, 1000, 10000 };
            Adder(happiness);

        }



        static double AverageGrades(int[] gradesArray)
        {
            int arrayLength = gradesArray.Length;
            double sumOfGrades = 0;

            foreach(int grade in gradesArray)
            {
                sumOfGrades = grade + grade;
            }

            double average = sumOfGrades / arrayLength;
            return average;
        }

        //challange method
        public static void Adder(int[] numsArray)
        {
            foreach(int num in numsArray)
            {
                int plusTwo = num + 2;
                Console.WriteLine(plusTwo);
            }
        }
    }
}
