using System;

namespace Enums
{
    // Should be called up in the namespace as is a constant

    enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

    // Have reassigned some values in Month. Can see if hover over with mouse what the new values are
    enum Month { Jan = 1, Feb, Mar, Apr, May, Jun = 15, Jul, Aug, Sep, Oct, Nov, Dec }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Can make variables like so
            Day fifthDay = Day.Friday;
            Day sabbath = Day.Sunday;

            Console.WriteLine(Day.Saturday);

            //can use casting to get the integer/index value
            Console.WriteLine((int)Day.Wednesday);

            Day a = Day.Friday;
            Console.WriteLine(fifthDay == a);

            Console.ReadKey();
        }
    }
}
