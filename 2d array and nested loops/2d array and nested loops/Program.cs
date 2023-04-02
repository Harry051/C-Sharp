using System;

namespace _2d_array_and_nested_loops
{
    internal class Program
    {
        static int[,] matrix =
{
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };
        static void Main(string[] args)
        {
            foreach(int v in matrix)
            {
                Console.Write(v + " ");
            }

            //Good to go through everything but if we want to access something SPECIFIC need a nested for loop.
            //Above we are just getting a value presented but can change things with below.

            Console.WriteLine("\nThis is our 2D array printed using a nested loop :)");
            //Nested for loop 
            //outer loop - for going through rows
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                //inner loop - for going through values
                for (int j = 0; j < matrix.GetLength(1); j++)  //the 1 in .GetLength indicatest that it wants to iterate through the SECOND DIMENSION
                {
                    //if put matrix[i, j] = 0     would change all array values to 0.
                    Console.WriteLine(matrix[i, j] + " ");
                }
            }
        }
    }
}
