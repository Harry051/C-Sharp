using System;
using System.IO;
using System.Text.RegularExpressions;

namespace regex_challange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myText = System.IO.File.ReadAllText(@"C:\Users\harry\Downloads\input2.txt");
            File.WriteAllText(@"C:\Users\harry\source\repos\regex challange\regex challange\ChallangeText.txt", myText);

            string myRegex = @"\d{2,3}";
            Regex regex = new Regex(myRegex);

            MatchCollection myMC = regex.Matches(myText);

            foreach (Match m in myMC)
            {
                //Console.WriteLine($"An example of your REGEX value: {m.Value} is found at index:{m.Index}");
                Int32.TryParse(m.Value, out int mAsInt);
                char mAsChar = (char)mAsInt;
                Console.Write(mAsChar);
            }

            Console.ReadKey();
        }
    }
}
