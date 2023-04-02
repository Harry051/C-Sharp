using System;

namespace multidimensional_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare a two dimensional array
            string[,] names;

            // a 3d         -can keep on going just add an extra comma for another dimension
            int[,,] figures;

            //to initialize
            int[,] array2D = new int[,]
            {
                {1, 2, 3 },     //Row 1
                {4, 5, 6 },     //Row 2
                {7, 8, 9 },     //Row 3
            };

            //To access a value need to pop in 2 numbers to say index of row then index of value
            Console.WriteLine($"The middle number is: {array2D[1, 1]}");



            //Can do another way to specify number of entries
            string[,] stringArray2D = new string[3, 2]     //<-- makes set that this array has 3 rows with 2 entries in each
            {
                {"one", "two"},
                {"three", "four" },
                {"five", "six" }
            };

            stringArray2D[1, 1] = "chicken";
            Console.WriteLine(stringArray2D[1, 1]);



            //Probs won't use a 3d often but here's what it looks like

            string[,,] demo = new string[,,]
            {
                {
                    {"000", "001", "002" },
                    {"010", "011", "012" },
                    {"020", "021", "022" }
                },
                {
                    {"100", "101", "102" },
                    {"110", "111", "112" },
                    {"120", "121", "122" }
                }
            };

            Console.WriteLine($"value is {demo[1, 2, 1]}");

            //A method to figure out nu,ber of dimensions is .Rank
            Console.WriteLine($"This array has {demo.Rank} dimensions.");


            Console.Read();


        }
    }
}
