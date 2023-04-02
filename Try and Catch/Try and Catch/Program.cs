using System;

namespace Try_and_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a number");
            string userInput = Console.ReadLine();
            
            try
            {
                int userInputAsInt = Int32.Parse(userInput);
            }
            /*catch(Exception)
            {
                throw;     // <--- will shut down the program and tell you the error
                //Console.WriteLine("Ooops, make sure you enter a number and not a letter :(");  < ---OR can write a general message
            } */
            catch(FormatException)
            {
                Console.WriteLine("It seems you put it something that wasn't a number");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Your number was too  big for Int32");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Field empty :( Please type something in");
            }
            finally
            {
                Console.WriteLine("This will show at the close of the program regardless of trying and catching");
            }

            Console.ReadKey();
           
        }
    }
}
