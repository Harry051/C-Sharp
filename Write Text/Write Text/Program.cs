using System;
using System.IO; //means we can use 'File' directly.

namespace Write_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1

            string[] extraLines = { ">\tYes you finished the Read section", ">\tBut now prepare for the Write section", ">\tDon't worry you can go to bed soon" };
            File.WriteAllLines(@"C:\Users\harry\source\repos\Write Text\txtfiles\test2.txt", extraLines);
            //by saying test file 2 will create AND write a file

            
            //Example 2
            /*
            Console.WriteLine("Please give your file a name:");
            string filename = Console.ReadLine();
            Console.WriteLine("Please enter the text for your file:");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\harry\source\repos\Write Text\txtfiles\" + filename + ".txt", text);
            */
            //Example 3
            string[] sabreOlympicMedallists = { "Gold: Aron Szilagyi from Hungary", "Silver: Luigi Samele from Italy", "Bronze: Junghwan Kim from South Korea" };
            using (StreamWriter file = new StreamWriter(@"C:\Users\harry\source\repos\Write Text\txtfiles\ThirdPlacers.txt"))
            {
                foreach(string line in sabreOlympicMedallists)
                {
                    if(line.Contains("Bronze"))
                    {
                        file.WriteLine(line);
                        Console.WriteLine("Third Place file has been created");
                    }
                }
            }
            
            //If you want to add more lines later do this.
            //bool true in params means will add rather than overwrite file
            using (StreamWriter file = new StreamWriter(@"C:\Users\harry\source\repos\Write Text\txtfiles\ThirdPlacers.txt", true))
            {
                file.WriteLine("Junghwan Kim also snagged a bronze in Rio 2016");
            }
            
                Console.ReadKey();

        }
    }
}
