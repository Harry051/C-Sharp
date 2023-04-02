using System;

namespace Methods
{
    internal class Program
    {
        /*
         * <Access Specifier> (static <Return Type> <Method Name>(parameter 1, parameter 2)
         *  {
         *   Method Body
         *  }
         */
        static void Main(string[] args)
        {
            MobyDick();
            NotMobyDick("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way—in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only.");
            Console.WriteLine(Add(12, 45));
            Console.WriteLine(Add(Add(1, 2), Add(3, 4))); // <--- will rarely use this but can do it.


            string friend1 = "Bob";
            string friend2 = "Anna";
            string friend3 = "Joey";
            Console.WriteLine(GreetFriend(friend1));
            Console.WriteLine(GreetFriend(friend2));
            Console.WriteLine(GreetFriend(friend3));


            Console.Read();
        }

        public static void MobyDick()
        {
            Console.WriteLine("Call me Ishmael. Some years ago—never mind how long precisely—having little or no money in my purse, and nothing particular to interest me on shore, I thought I would sail about a little and see the watery part of the world. It is a way I have of driving off the spleen and regulating the circulation. Whenever I find myself growing grim about the mouth; whenever it is a damp, drizzly November in my soul; whenever I find myself involuntarily pausing before coffin warehouses, and bringing up the rear of every funeral I meet; and especially whenever my hypos get such an upper hand of me, that it requires a strong moral principle to prevent me from deliberately stepping into the street, and methodically knocking people’s hats off—then, I account it high time tozz get to sea as soon as I can. This is my substitute for pistol and ball. With a philosophical flourish Cato throws himself upon his sword; I quietly take to the ship. There is nothing surprising in this. If they but knew it, almost all men in their degree, some time or other, cherish very nearly the same feelings towards the ocean with me.");
        }

        public static void NotMobyDick(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
            //Need to use DOUBLES for division as numbers can be decimal so int won't be precise enough.
            //ALWAYS THINK ABOUT DATATYPES!
        }
        

        //Exercise 1 -- Greet 3 friends
        public static string GreetFriend(string friendName)
        {
            return $"Hi {friendName} my friend";
        }
    }
}
