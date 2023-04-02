using System;

namespace String_Manipulation_and_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Harry";
            int age = 28;
            string job = "art technician/fullstack developer";

            // String Concatination
            Console.WriteLine("String Concatination");
            Console.WriteLine("Hello my name is " + name + " and I am " + age + " years old.");

            // String Formatting
            Console.WriteLine("String Fromatting");
            Console.WriteLine("Hello my name is {0} and I am {1} years old. I work as a {2}.", name, age,job);
            //uses the index in curly brackets to pull whatever is after the commas

            // String Interpolation
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name} and I am {age} years old");

            // Verbatim String
            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(@"Lorem       ipsum dolor /n sit amet");
            Console.WriteLine(@"C:\Users\harry\source\repos\String Manipulation and Methods\String Manipulation and Methods\String Manipulation and Methods.csproj");

            /* Verbatim strings start with an @ symbol and tell the compiler to take
             * the string literally and will ignore any spaces or escape characters (such as /n for newline).
             */


            // Various methods
            string firstName = "Harry";
            string lastName = "Cundall";
            string fullName = $"{firstName} {lastName}  ";
            Console.WriteLine(firstName.Substring(2)); //starts string from index to - will print 'rry'
            Console.WriteLine(firstName.ToLower()); //make all lower case
            Console.WriteLine(firstName.ToUpper()); //make all uppercase
            Console.WriteLine(fullName.Trim()); //removes whitespace
            Console.WriteLine(firstName.IndexOf('a')); //finds 1st instance of a will print index -- '1'
            Console.WriteLine(String.IsNullOrWhiteSpace(firstName)); //false as is text there
            Console.WriteLine(String.Format("My name is {0}", firstName)); // will insert variable into text
        }
    }
}
