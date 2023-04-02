using System;

namespace jagged_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare the array
            int[][] jaggedArray = new int[3][];  // <-- saying want 3 arrays WTIHIN the jagged array
            
                // Give values for how long each array will be
                jaggedArray[0] = new int[5];
                jaggedArray[1] = new int[4];
                jaggedArray[2] = new int[3];

                //Put the info into the arrays
                jaggedArray[0] = new int[] {1, 3, 5, 7, 9 };
                jaggedArray[1] = new int[] { 2, 4, 6, 8 };
                jaggedArray[2] = new int[] { 10, 20, 30 };


            int[] myFavouriteNumbers = new int[] { 51, 1, 100 };

            //Alternatively
            int[][] jaggedArray2 = new int[][]  // <-- by leaving blank we are free to declare as many sub-arrays as we like
            {
                new int[] {2, 8, 12, 200, 94},
                new int[] { 1, 0 },
                new int[] { 568732537, 3, -100, 2, 89, 241, 53546, 232, 3463},
                myFavouriteNumbers //<-- can even add in earlier declared arrays

            };

            Console.WriteLine($"The value of the second entry in the second array is: {jaggedArray2[1][1]}");

            foreach(int[] i in jaggedArray2)
            {
                foreach(int j in i)
                Console.WriteLine($"All the values are: {j}");
            }
       
            Console.ReadKey();

        }
    }
}
