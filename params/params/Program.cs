using System;

namespace paramLesson
{
    internal class Program
{
    static void Main(string[] args)
    {
        string[] myStory = { "Once", "upon", "a", "time", "I", "made", "an", "amazing", "array", "..." }; // This can go on forever
        ParamsMethod(myStory);

            int num = 51;
            bool coolness = true;
            string vibe = "mellow";
            char at = '@';
            ParamsMethod2(num, coolness, vibe, at);
            ParamsMethod2(2, "Hello there Captain Ahab", 7.96892, false, true, 'P');


            int whatIsSmall = findSmallestNumber(2, 384, 23, 987876757, 77, 1547, 3);
            Console.WriteLine($"The smallest number from your list is: {whatIsSmall}");
    }

    public static void ParamsMethod(params string[] sentence)
            //By using params keyword allows method to take a VARIABLE number of arguments from 0 to infinite
            //In a nutshell lets the method be open and playful
            //Important to note no additional parameters are permitted after the params keyword in the method decleration
    {
        for(int i = 0; i < sentence.Length; i++)
        {
            Console.WriteLine(sentence[i] + " ");
        }
    }

        public static void ParamsMethod2(params object[] generalData)
        {
            foreach(object obj in generalData)
            {
                Console.WriteLine($"{obj} ");
            }
        }

        //Real World example
        public static int findSmallestNumber(params int[] numbers)
        {
            int smallest = int.MaxValue;

            foreach(int number in numbers)
            {
                if(number < smallest)
                {
                    smallest = number;
                }
            }
            return smallest;
        }
}
}
