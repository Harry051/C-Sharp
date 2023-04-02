using System;
using System.IO;
using System.Linq;

namespace Read_Write_Challange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\harry\source\repos\Read Write Challange\challange text\input.txt");
            string[] splitLines = lines;

            using (StreamWriter file = new StreamWriter(@"C:\Users\harry\source\repos\Read Write Challange\challange text\solution1.txt"))
            {
                foreach (string line in splitLines)
                {
                    if (line.Contains("split"))
                    {
                        string[] myletters = line.Split();
                        //Console.Write(myletters[4] + " ");                     
                        file.Write(myletters[4] + " ");                      

                    }
                }
            }


            Console.WriteLine("New file created");
            Console.ReadKey();
        }
    }
}
