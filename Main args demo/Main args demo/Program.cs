using System;

namespace Main_args_demo
{
    internal class Program
    {
        //Go to properties, Debug, Command Line Argument
        static void Main(string[] args)
        {         
            //Console.WriteLine("Hello " + args[0]);    <-- if an argument of 'Harry' will write "Hello Harry"

            //the args array cannot be null. So, it's safe to access the Length property without null checking.
            //so we check the length of the array. If it's zero it means that no args were passed to the applicaiton.

            if(args.Length == 0)
            {
                Console.WriteLine("This demo is about args. Please provide some next time");

                //pause the application so it doesn't quit after printing
                Console.ReadKey();

                //quit the applicaiton since we can't proceed as the arguments are empty
                return;
            }
            Console.WriteLine("Hello " + args[0]);
            Console.ReadKey();

            //If Open it with command line, will say This demo is about args etc...
            //However if type argument of "harry" after opening, will run the program "Hello Harry instead"


        }
    }
}
