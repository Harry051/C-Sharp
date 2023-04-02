using System;

namespace try_and_catch_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Try and divide something by zero.

            try
            {
                Divide(4, 0);
            }
            /*catch(Exception)
            {
                throw; // <-- when I run this it tells me the exception can't by divide by zero
            }
                SO need to write a more specific catch below.
            */
            catch(DivideByZeroException)
            {
                Console.WriteLine("Oh dear, it appears you tried to divide something by zero.");
            }
            finally
            {
                Console.WriteLine("Thanks for using my program!!!!");
            }
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
