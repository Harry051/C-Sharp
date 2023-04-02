using System;

namespace Events_and_MultiCast_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
                       //Create an audio system
                       AudioSystem audiosystem = new AudioSystem();
                       //create a new rendering engine
                       RenderingEngine renderingEngine = new RenderingEngine();

                       //create 2 players and give them names.
                       Player player1 = new Player("Sniper420");
                       Player player2 = new Player("XxGOALTIMExX");


/*
                       //start the audio system and rendering engine
                       audiosystem.StartGame();
                       renderingEngine.StartGame();

                       //spawn the players
                       player1.StartGame();
                       player2.StartGame();

                       Console.WriteLine("Game is running... Press any button to end the game.");

                       //pause
                       Console.Read();

                       //shut down the engines
                       audiosystem.GameOver();
                       renderingEngine.GameOver();

                       //Remove the players
                       player1.GameOver();
                       player2.GameOver();

                       Console.WriteLine("--------------------------------------------");

           */

            GameEventManager.TriggerGameStart();
            Console.WriteLine("Game is running... Press any button to end the game.");
            Console.Read();
            GameEventManager.TriggerGameOver();

            //Can see these 4 lines of code a lot more simple
            //And if wanted to add new players/systems etc. Wouldn't have to do it manually would just work.

            Console.ReadKey();


        }
    }
}
