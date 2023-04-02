using System;

namespace foreach_switch_challange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            //char[] alphabetChar = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            // nice idea but not needed
            Console.WriteLine("Please type something");
            string userInput1 = Console.ReadLine();

            Console.WriteLine("What kind of data type was your first value?\n1. String\n2. Integer\n3. Boolean");
            string userInput2 = Console.ReadLine();


               
            
                switch (userInput2)
                {
                case "1":
                    Console.WriteLine($"You typed in {userInput1}");
                    if(IsString(userInput1))
                    {
                        Console.WriteLine("This is a valid string");
                    }
                    else
                    {
                        Console.WriteLine("This is not a string");
                    }
                    
                    break;
                case "2":
                    Console.WriteLine($"You typed in {userInput1}");

                    int input1Int;
                    bool isInt = Int32.TryParse(userInput1, out input1Int);
                    if(isInt)
                    {
                        Console.WriteLine("It is a valid integer");
                    }
                    else
                    {
                        Console.WriteLine("In is not an integer");
                    }
                    break;

                case"3":
                    Console.WriteLine($"You typed in {userInput1}");

                    bool input1Bool;
                    bool isBool = bool.TryParse(userInput1, out input1Bool);

                    
                    if (isBool)
                    {
                        Console.WriteLine("A valid Boolean");
                    }
                    else
                    {
                        Console.WriteLine("This is not a Boolean");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid you must select 1 2 or 3");
                    break;
                }
            
        }

        
        public static bool IsString(string message)
        {
                       
            foreach (char letter in message)
            {
                if(!char.IsLetter(letter))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
