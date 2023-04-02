using System;

namespace Interfaces_intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket t1 = new Ticket(126);
            Ticket t2 = new Ticket(126);

            Console.WriteLine(t1.Equals(t2));
        }
    }
}
