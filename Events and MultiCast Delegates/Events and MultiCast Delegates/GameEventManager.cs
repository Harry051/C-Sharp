using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_MultiCast_Delegates
{
    internal class GameEventManager
    {
        //A new delegate type called game event
        public delegate void GameEvent();

        //Create two new delegate variables
        public static event GameEvent OnGameStart, OnGameOver; //<-- EVENT keyword helps to prevent errors

        //Can override a delegate but only subscribe to an event

        public static void TriggerGameStart()
        {
            if(OnGameStart != null)
            {
                Console.WriteLine("The game has started...");
                //call the OnGameStart that will trigger all methods tied to this event
                OnGameStart();
            }
        }

        public static void TriggerGameOver()
        {
            if(OnGameOver != null)
            {
                Console.WriteLine("Game is shutting down...");
                OnGameOver();
            }
        }
    }
}
