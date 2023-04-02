using System;
using System.Collections.Generic;

namespace IEnumerable_Exampels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> mysteryCollection;
            mysteryCollection = GetCollection(1);

            Console.WriteLine("\nYour collection was a List!\nThe values are:");
            foreach (int num in mysteryCollection)
            {
                Console.Write(num + " ");
            }

            mysteryCollection = GetCollection(2);
            Console.WriteLine("\nYour collection was a Queue!\nThe values are:");
            foreach (int num in mysteryCollection)
            {
                Console.Write(num + " ");
            }

            mysteryCollection = GetCollection(3);
            Console.WriteLine("\nYour collection was an Array!\nThe values are:");
            foreach (int num in mysteryCollection)
            {
                Console.Write(num + " ");
            }

            //---------------------------------
            List<int> numberList = new List<int> { 1, 2, 3, 4, 5 };
            SumOfCollection(numberList);
            int[] numberArray = new int[] { 11, 12, 13, 14, 15 };
            SumOfCollection(numberArray);

        }

        static IEnumerable<int> GetCollection(int option)
        {
            // Create a list of numbers and initialize it
            List<int> numberList = new List<int> { 1, 2, 3, 4, 5 };

            // Make a queue and initialize it
            Queue<int> numberQueue = new Queue<int>();

            numberQueue.Enqueue(6);
            numberQueue.Enqueue(7);
            numberQueue.Enqueue(8);
            numberQueue.Enqueue(9);
            numberQueue.Enqueue(10);

            if (option == 1)
            {
                return numberList;
            }
            else if (option == 2)
            {
                return numberQueue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }

        }


        //Part 2 - Can also use IEnumerable WITHIN methods.

        static void SumOfCollection(IEnumerable<int> anyCollection)
        {
            // make a variable to store the sum of number in the collection
            int sum = 0;

            //iterate through the collection
            foreach(int num in anyCollection)
            {
                sum = sum + num;
            }
            Console.WriteLine($"The sum of your numbers is {sum}");
        }
    }
}
