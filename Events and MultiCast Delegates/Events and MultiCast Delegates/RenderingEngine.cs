using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_MultiCast_Delegates
{
    internal class RenderingEngine
    {
        public RenderingEngine()
        {
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
            //Although methods are named the same as in audio class, will use the methods from THIS CLASS
        }

        //At the start of the game we want to enable the rendering engine and start drawing the visuals
        public void StartGame()
        {
            Console.WriteLine("Rendereing engine started");
            Console.WriteLine("Drawing Visuals....");
        }

        //When the game is over we want to stop our rendering engine
        public void GameOver()
        {
            Console.WriteLine("Rendering Engine stopped");
        }
    }
}
