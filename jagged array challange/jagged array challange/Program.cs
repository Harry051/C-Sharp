using System;

namespace jagged_array_challange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a jagged array 3 friends array with 2 family members in each
            // introduce to eacj other

            string[][] friendList = new string[][]
            {
                new string[] {"Will", "Fiona"},
                new string[] {"Nick", "Sarah"},
                new string[] {"Claire", "Tim"}
            };

            Console.WriteLine($"Hi {friendList[0][0]} I'd like to introduce you to {friendList[2][1]}");
            Console.WriteLine($"Hi {friendList[1][1]} I'd like to introduce you to {friendList[0][1]}");
            Console.WriteLine($"Hi {friendList[1][0]} I'd like to introduce you to {friendList[2][0]}");
            Console.ReadKey();


        }
    }
}
