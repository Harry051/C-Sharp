using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_MultiCast_Delegates
{
    internal class Player
    {

        public string PlayerName { get; set; }

        //Simple Constructor
        public Player(string name)
        {
            this.PlayerName = name;
            //subscribe to the OnGameStart and OnGameOver events

            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        //At the start of the game spawn the player
        private void StartGame()
        {
            Console.WriteLine($"Spawning player {PlayerName}");
        }

        //When the game is over remove the player
        private void GameOver()
        {
            Console.WriteLine($"Removing player: {PlayerName}");
        }

    }
}
