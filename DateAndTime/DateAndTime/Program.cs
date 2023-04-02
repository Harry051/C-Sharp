using System;

namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday = new DateTime(2023, 7, 1);
            Console.WriteLine($"My birthday will be on: {birthday}");

            //Todays date
            Console.WriteLine(DateTime.Today);

            //Current time
            Console.WriteLine(DateTime.Now);

            //Have to make a method to get tomoz
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine($"Tomorrow will be {tomorrow}");

            //Get day of the week
            DayOfWeek todaysDay = DateTime.Today.DayOfWeek;
            Console.WriteLine($"It is {todaysDay} today");

            //First day of year
            Console.WriteLine(GetFirstDayOfYear(1999));


            int days = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine(days);

            DateTime rightNow = DateTime.Now;
            Console.WriteLine($"the current minute past the hour is {rightNow.Minute}");
            Console.WriteLine($"It is {rightNow.Hour} o'clock {rightNow.Minute} minutes and {rightNow.Second} seconds");

            // Days since program
            Console.WriteLine("Please write a date in this format yyyy-mm-dd");
            string userDate = Console.ReadLine();
            if(DateTime.TryParse(userDate, out DateTime userDateParsed))
            {
                Console.WriteLine(userDateParsed);
                TimeSpan daysSince = rightNow - userDateParsed;
                Console.WriteLine($"{daysSince.Days} days have passed since your {userDateParsed}");
            }
            else
            {
                Console.WriteLine("Incorrect input, please try again");
            }

            Console.ReadKey();

        }

        static DateTime GetTomorrow()
        {
            return DateTime.Now.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }

    }
}
