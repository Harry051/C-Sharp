using System;

namespace Loops_challange
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Class average grade calculator.");
            float totalScore = 0;
            int loopCounter = 0;
            string score;
            do
            {
                loopCounter++;
                Console.WriteLine("--------------------------");
                Console.WriteLine("Add a students score");
                score = Console.ReadLine();
                float scoreInt = float.Parse(score);
                if(scoreInt < 0 || scoreInt > 20)
                {
                    Console.WriteLine("Invalid score");
                    break;
                }
                Console.WriteLine($"You added {scoreInt}");
                totalScore = totalScore + scoreInt;
                float average = totalScore / loopCounter;
                
                Console.WriteLine($"The new average is {average}");
                Console.WriteLine("To exit press -1");
                           
            } while(score != "-1");

            Console.Read();
        }
    }
}
// if -1 entered program closes
//has to verify a number
//numbers entered can only be between 0-20