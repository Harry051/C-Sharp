using System;

namespace Structs
{

        // Although very similar to a Class. A Struct must return a value
        // Also they can not implement Constructors
        // They do NOT support Inheritance
        // Can't have a null reference      All values MUST be assigned.
    struct Game
    {
 
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public void DisplayInfo()
        {
            Console.WriteLine($"The first game is called {name}, developed by {developer}.\nIt scored a rating of {rating}.\tReleased on {releaseDate}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Game fifa;

            fifa.name = "FIFA 2023";
            fifa.developer = "EA Sports";
            fifa.rating = 4.2;
            fifa.releaseDate = "3rd March 2023";

            fifa.DisplayInfo();


            Console.ReadKey();

        }
    }
}
