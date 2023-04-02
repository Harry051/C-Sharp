using System;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            /* old way of assigning values publically
            //box1.length;
            //box1.height = 6;
            //box1.width = 2;
            */


            // wont work unless you call the .SetLength() Method as length is now private
            box1.SetLength(5);

            // proper notation for a setter
            box1.Height = 6;

            box1.Width = 2;

            // This allows you to read the value of the member variable from outside the class despite it being private
            Console.WriteLine($"The length of box1 is {box1.GetLength()}");
            box1.DisplayInfo();
        }
    }
}
