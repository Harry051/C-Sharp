using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_MultiCast_Delegates
{
    internal class AudioSystem
    {
        //Simple Constructor
        public AudioSystem()
        {
            //Subscribe to OnGameStart and OnGameOver events
            // V IMPORTANT use +=, if just = will override with just one class definition
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }


        //At the start of the game we want to enable the audio and start playing the sounds
        private void StartGame()
        {
            Console.WriteLine("Audio System booted");
            Console.WriteLine("Playing Audio...");
        }

        //When the game is over we want to stop the audio

        private void GameOver()
        {
            Console.WriteLine("Audio system stopped");
        }
    }
}
