using System;
using System.Security.Cryptography.X509Certificates;

namespace Noughts_and_Crosses_Exercise
{

    /*To do
     * 1. sort out while loop so that dont have to wait for p1 to win
     * 2. add in an if else to turn cases so that can't go over a spot already played
     */ 
    internal class Program
    {
        public static string[,] board = new string[,]
        {
            {"1", "2", "3" }, // 00, 01, 02
            {"4", "5", "6" }, // 10, 11, 12
            {"7", "8", "9" }  // 20, 21, 22
        };
        static void Main(string[] args)
        {
            for (int counter = 0; counter < 100; counter++)
            {
                Console.WriteLine("Press enter to start a game of Noughts and Crosses:");
                Console.ReadKey();
                ShowBoard();

                do
                {
                    player1Turn();
                    player2Turn();
                } while (!WinConditions());
                //at present only needs to let player 2 have a turn before declaring a winner

                ResetGame();
            }


        }

        static void ShowBoard()
        {
            Console.WriteLine($" {board[0, 0]} | {board[0, 1]} | {board[0, 2]}");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[1, 0]} | {board[1, 1]} | {board[1, 2]}");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[2, 0]} | {board[2, 1]} | {board[2, 2]}");


        }
        public static void player1Turn()
        {
            Console.WriteLine("Player One, type in a number:");
            string player1Input = Console.ReadLine();
          
            Console.Clear();
            int player1InputInt;
            bool player1Parse = int.TryParse(player1Input, out player1InputInt);
            switch (player1InputInt)
            {
                case 1:
                    board[0, 0] = "O";
                    ShowBoard();
                    break;
                case 2:
                    board[0, 1] = "O";
                    ShowBoard();
                    break;
                case 3:
                    board[0, 2] = "O";
                    ShowBoard();
                    break;
                case 4:
                    board[1, 0] = "O";
                    ShowBoard();
                    break;
                case 5:
                    board[1, 1] = "O";
                    ShowBoard();
                    break;
                case 6:
                    board[1, 2] = "O";
                    ShowBoard();
                    break;
                case 7:
                    board[2, 0] = "O";
                    ShowBoard();
                    break;
                case 8:
                    board[2, 1] = "O";
                    ShowBoard();
                    break;
                case 9:
                    board[2, 2] = "O";
                    ShowBoard();
                    break;
                default:
                    Console.WriteLine("Invalid entry, try again");
                    ShowBoard();
                    player1Turn();
                    break;
            }


        }
        public static void player2Turn()
        {
            Console.WriteLine("Player Two, type in a number:");
            string player2Input = Console.ReadLine();
            Console.Clear();
            int player2InputInt;
            bool player2Parse = int.TryParse(player2Input, out player2InputInt);
            switch (player2InputInt)
            {
                case 1:
                    board[0, 0] = "X";
                    ShowBoard();
                    break;
                case 2:
                    board[0, 1] = "X";
                    ShowBoard();
                    break;
                case 3:
                    board[0, 2] = "X";
                    ShowBoard();
                    break;
                case 4:
                    board[1, 0] = "X";
                    ShowBoard();
                    break;
                case 5:
                    board[1, 1] = "X";
                    ShowBoard();
                    break;
                case 6:
                    board[1, 2] = "X";
                    ShowBoard();
                    break;
                case 7:
                    board[2, 0] = "X";
                    ShowBoard();
                    break;
                case 8:
                    board[2, 1] = "X";
                    ShowBoard();
                    break;
                case 9:
                    board[2, 2] = "X";
                    ShowBoard();
                    break;
                default:
                    Console.WriteLine("Invalid entry, try again");
                    ShowBoard();
                    player2Turn();
                    break;
            }
        }
        public static bool WinConditions()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    {
                        Console.WriteLine("Congratulations we have a winner!");                       
                        return true;
                        
                    }
                    else if (board[0, j] == board[1, j] && board[1, j] == board[2, j])
                    {
                        Console.WriteLine("Congratulations we have a winner!");
                        return true;
                    }

                }
            }
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                Console.WriteLine("Congratulations we have a winner!");
                return true;
            }
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                Console.WriteLine("Congratulations we have a winner!");
                return true;
            }
              
            return false;
            
        }
                
        public static void ResetGame()
        {
            string[,] freshBoard =
            {
            {"1", "2", "3" }, // 00, 01, 02
            {"4", "5", "6" }, // 10, 11, 12
            {"7", "8", "9" }  // 20, 21, 22
            };
            board = freshBoard;
            Console.WriteLine("Press enter to play again");
            Console.ReadKey();
            Console.Clear();
        }

        /*  FINISH METHOD
         *  
        public static void TilePlayed()
        {
            foreach (string arrayValue in board)
            {
                if (arrayValue == "O" || arrayValue == "X")
                {
                    Console.WriteLine("Invalid Entry, tile has already been played");
                    ShowBoard();
                    break;
                }
                else
                {
                    ShowBoard();
                }
            }
        }  */
    }
}
