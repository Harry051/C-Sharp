using System;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1

            string myName;
            Console.WriteLine("Please enter your name and press enter:");
            myName = Console.ReadLine();

            string upperName = String.Format($"Uppercase = {myName.ToUpper()}");
            string lowerName = String.Format($"Lowercase = {myName.ToLower()}");
            string trimmed = String.Format($"Trimmed = {myName.Trim()}");
            string subName = String.Format($"substring = {myName.Substring(2, 6)}");

            Console.WriteLine(upperName);
            Console.WriteLine(lowerName);
            Console.WriteLine(trimmed);
            Console.WriteLine(subName);

            Console.ReadKey();
          

            //Part 2

            string myString;
            char myChar;
            string firstName;
            string lastName;

            Console.WriteLine("Please type something in:");
            myString = Console.ReadLine();

            Console.WriteLine("Which Character would you like to search for?");
            myChar = Console.ReadLine()[0];

            int index = myString.IndexOf(myChar);

            Console.WriteLine($"The first instance of your chosen letter is at index: {index}");


            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your second name?");
            lastName = Console.ReadLine();
            Console.WriteLine($"Your full name is: {firstName} {lastName}");
            
            //Part 3
            sbyte mySbyte = 1;
            Console.WriteLine(mySbyte);
            int myInt = 10;
            Console.WriteLine(myInt);
            short myShort = 100;
            Console.WriteLine(myShort);
            long myLong = 1000;
            Console.WriteLine(myLong);
            float myFloat = 1.1f;
            Console.WriteLine(myFloat);
            double myDouble = 1.12;
            Console.WriteLine(myDouble);
            decimal myDecimal = 1.123m;
            Console.WriteLine(myDecimal);
            char myChar2 = 'H';
            Console.WriteLine(myChar2);
            string myString2 = "Harry";
            Console.WriteLine(myString2);
            bool isItLunchtime = true;
            Console.WriteLine(isItLunchtime);

            string intro = "I control text";
            string outro = "50";
            int newOutro = Int32.Parse(outro);
            Console.WriteLine(newOutro);

        }
    }
}
