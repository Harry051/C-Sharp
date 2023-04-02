using System;
using System.Globalization;

namespace Nested_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            Console.WriteLine("Please enter your username:");
            string username = Console.ReadLine();

            if(isRegistered)
            {
                Console.WriteLine("Hi there Registered User");
                if(username != "")
                {
                    Console.WriteLine($"Hi there {username}");
                    if(username.Equals("Admin"))
                    {
                        Console.WriteLine("Welcome to the Adminzone");
                    }
                }
            }
            //Alternatively can do all on one line
            // if(usRegistered && username != "" && username.Equals("Admin")
        }
    }
}
