using System;

namespace _2d_loop_challange_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                {1, 2, 3 },     // 00  01  02
                {4, 5, 6 },     // 10  11  12
                {7, 8, 9 }      // 20  21  22
            };


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                        Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(" "); //Gets us 159 diagonal
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i + j == 2)
                        Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(" "); //Gets us 357 diagonal
            }
            
            /*Alternatively could've done it this way
             * 
             * for(int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
             *  {
             *      Console.WriteLine(matrix[i, j]);
             *  }
             */



        }   
    }
}

