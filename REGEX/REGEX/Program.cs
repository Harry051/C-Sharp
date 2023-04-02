using System;
using System.Text.RegularExpressions;

namespace REGEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d"; //need @ symbol so text is taken verbatim
            //can change regex in pattern and see what it finds :)

            Regex myRegex = new Regex(pattern);

            string text = "hi there my number is 10361";

            MatchCollection myMC = myRegex.Matches(text);   //.Matches a built in method

            Console.WriteLine($"{myMC.Count} hits found for REGEX in: {text}");

            foreach(Match m in myMC)
            {
                Console.WriteLine($"{m.Value} found at index {m.Index}");
            }

            Console.ReadKey();




        }
    }
}
