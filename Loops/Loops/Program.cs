using System;
using System.Diagnostics.Tracing;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 Kinds of loop

            // 1. For
            /*
             *  for(start value; condition; increment;)
             *  {
             *  code body
             *  }
            */
            for (int counter = 0; counter < 50; counter += 5)
            {
                Console.WriteLine(counter);
            }


            //2. While
            /*
             *  int counterVariable = 0;
             *  while(condition)
             *  {
             *  code body
             *  counterVariable ++;
             *  }
             */

            int number = 0;
            while(number <= 10)
            {
                Console.WriteLine($"While Loop number {number}");
                number++;
            }




            // 3. Do While
            /*
             *  int counterVariable = 0;
             *  do {
             *  code body
             *  counterVariable ++;
             *  } while(condition);
             */

            int counting = 15;
            do
            {
                Console.WriteLine(counting);
                counting++;
            } while (counting < 5);
            //Will run once regardless of while statement and then continue until while condition is met.
            //WARNING if while condition not met will make an INFINITE loop :(

            int lengthOfText = 0;
            string allFriends = "";

            do
            {
                Console.WriteLine("Please enter the name of a friend:");
                string friendName = Console.ReadLine();
                int currentLength = friendName.Length;
                lengthOfText += currentLength;
                allFriends += friendName;
            } while (lengthOfText < 20);
            Console.WriteLine($"That's enough for now. Your friends are {allFriends}");
            
            
            Console.Read();

            // 4. For Each
            /*
             * foreach(string movie in MyMovies)
             * {
             * Console.WriteLine(movie);
             * }
             */

            int[] nums = { 5, 7, 22, 31 };
            int loopCounter = 0;
            foreach(int arrayValue in nums)
            {
                Console.WriteLine($"Array entry {loopCounter} = {arrayValue}");
                loopCounter++;
            }

            /*
            string[] buddyNames = { "Rich", "Hannah", "Matt", "Laura", "Jamie" };
            int buddyCounter = 0;
            foreach(string name in buddyNames)
            {
                Console.WriteLine($"Good morning {name}");
                buddyCounter++;
            }
            */

        }
    }       
}
