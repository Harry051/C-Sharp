using System;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;

namespace ReadText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1

            string myText = System.IO.File.ReadAllText(@"C:\Users\harry\source\repos\Write Text\txtfiles\test.txt");
            //IO = Input Output
            //@ symbol means verbatim. Won't recognize escape characters. Good for filepaths
            Console.WriteLine(myText);

            //Example 2
            //Will go line by line
            string[] myLines = System.IO.File.ReadAllLines(@"C:\Users\harry\source\repos\Write Text\txtfiles\test.txt");
            foreach (string line in myLines)
            {
                Console.WriteLine($"> \t {line}");
                // \t means will put in a tab
            }

            Console.ReadKey();
        }
    }
}
