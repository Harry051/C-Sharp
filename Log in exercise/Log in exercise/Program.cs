using System;

namespace Log_in_exercise
{
    internal class Program
    {
        static string username;
        static string password;
        static string passwordCheck;
        static void Main(string[] args)
        {
            Registration();
            LogIn();
            Console.Read();
        }

        static void Registration()
        {
            Console.WriteLine("Please register, please choose a username?");
            username = Console.ReadLine();
            Console.WriteLine($"Excellent {username} and what would you like your password to be?");
            password = Console.ReadLine();
            Console.WriteLine("Please confirm your password:");
            passwordCheck = Console.ReadLine();

            if (password.Equals(passwordCheck))
            {
                Console.WriteLine("Thanks for Registering {0} :)", username);
                Console.WriteLine("--------------------------------------------");
            }
            else
            {
                Console.WriteLine("error passwords do not match, please start again.");
            }
        }

        public static void LogIn()
        {
            Console.WriteLine("To Log in enter your username:");
            string logInUsername = Console.ReadLine();
            if(logInUsername.Equals(username))
            {
                Console.WriteLine("Enter your password:");
                string logInPassword = Console.ReadLine();
                if(logInPassword.Equals(passwordCheck))
                {
                    Console.WriteLine($"Welcome back {username}");
                }
                else
                {
                    Console.WriteLine("Incorrect Password");
                }
            }
            else
            {
                Console.WriteLine("Username invalid");
            }
        }
    }
}
