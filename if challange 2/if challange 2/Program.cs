using System;
using System.Security.Cryptography;

namespace if_challange_2
{
    internal class Program
    {
        
        static int highScore = 20;     
        static string highScorePlayer = "Annie";
        static void Main(string[] args)
        {
            Console.WriteLine("Hey new player, what's your name?");
            string playerName = Console.ReadLine();
            Random rnd = new Random();
            int score = rnd.Next(0, 30);

            Console.WriteLine("Press enter to play");
            Console.ReadKey();
                            
            Console.WriteLine($"Woooooow you got a score of {score}");
            HighScoreCheck(score, playerName);

            Console.Read();
        }

        public static void HighScoreCheck(int score, string playerName)
        {
            if(score > highScore)
            {
                highScore = score;
                highScorePlayer = playerName;
                Console.WriteLine($"Wow new high score of {score}!");
                Console.WriteLine($"{playerName} is the new recordholder!");
            }
            else
            {
                Console.WriteLine($"Bad luck {highScorePlayer} still holds the record of {highScore} points");
            }
        }
    }
}
//Create a method which has two parameters, one for the score and one for the playerName.