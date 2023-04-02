using System;

namespace If_else
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What's the current temperature outside?");
            string userTemperature = Console.ReadLine();
            float temperature = Int32.Parse(userTemperature);

            if(temperature < 15)
            {
                Console.WriteLine("Get a coat");
            }
            else if(temperature == 15)
            {
                Console.WriteLine("Your probably alright");
            }
            else
            {
                Console.WriteLine("Sun's out guns out");
            }
            



            string num = "128f";
            int numParsed; //= int.Parse(num);
            bool success = int.TryParse(num, out numParsed);

            if (success)
            { 
                Console.WriteLine($"Your parsed number is: {numParsed}");
            }
            else
            {
                numParsed = 0;
                Console.WriteLine("Parsing unsuccessful");
            }


            //Also have switch statements, like if, else but cleaner to apply to a large number of cases.

            int age = 19;

            switch(age)
            {
                case 15:
                    Console.WriteLine("Too young to come into the bar");
                    break;
                case 16:
                    Console.WriteLine("Need to be accompanied by parents.");
                    break;
                case > 18:
                    Console.WriteLine("What would you like to drink?");
                    break;
                default:
                    Console.WriteLine("Can I see some ID?");
                    break;
            }

            // Ternary Operator is essentially a simple if else statement on one line
            int celcius = 20;
            string stateOfMatter = celcius < 0 ? "solid" : "liquid";
            Console.WriteLine(stateOfMatter);

            //Can take this one step further however and stack ternary operators
            celcius += 100;
            stateOfMatter = celcius > 100 ? "gas" : celcius < 0 ? "solid" : "liquid";
            Console.WriteLine(stateOfMatter);

        }
    }
}
