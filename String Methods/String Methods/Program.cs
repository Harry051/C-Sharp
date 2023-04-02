using System;

namespace String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Harry";
            string message = "I am called " + myName;
            // type in 'message.' and will automatically be given a variety of built in methods

            string capsMessage = message.ToUpper();
            Console.WriteLine(capsMessage);

            //let's play with some methods :)
            string[] splitMessage = message.Split();
            Console.WriteLine(splitMessage);
        }
    }
}
