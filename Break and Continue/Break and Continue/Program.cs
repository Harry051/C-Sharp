using System;

namespace Break_and_Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter < 10; counter++)
            {
                Console.WriteLine(counter);
                    if(counter == 3)
                {
                    Console.WriteLine("We stop at 3");
                    break;
                }
            }
            // By using the break keyword we can bust out of a loop at the time of our choosing



            for (int counter = 1; counter < 10; counter++)
            {
                if (counter == 3)
                {
                    Console.WriteLine("I'm different from the rest");
                    continue;
                }
                Console.WriteLine(counter);
            }
            // Continue keyword can be used to change particular runs of the loop
            // another example
            for (int counter = 1; counter < 10; counter++)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine("The next number is odd!");
                    continue;
                }
                Console.WriteLine(counter);
            }
        }
    }
}
