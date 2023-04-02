using System;

namespace Properties_challange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Challange: create a Read-Only Property called 'FrontSurface' which calculates the front surface from height and leng5th
            Box challangeBox = new Box(5, 10, 2);
            Console.WriteLine($"Your box height is {challangeBox.Height}\nYour box length is {challangeBox.Length}\nYour box width is {challangeBox.Width}");
            Console.WriteLine($"The front side of your box is {challangeBox.FrontSurface} cm2");
            Console.WriteLine($"The volume of your box is {challangeBox.Volume} cm3");

        }
    }
}
