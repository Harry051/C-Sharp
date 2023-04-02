using System;
using System.Collections.Generic;

namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //defining a stack
            Stack<int> myStack = new Stack<int>();

            // A stack can hold any type of objecy: string, classes etc. but only ONE TYPE PER STACK


            // Add elements to a stack
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(1337);

            //See what is in stack
            Console.WriteLine($"the top of the stack is: {myStack.Peek()}");

            myStack.Push(100);
            Console.WriteLine($"the top of the stack is: {myStack.Peek()}"); //<-- Will always show the latest entry


            int lastStackItem = myStack.Pop(); //<-- removes last thing in stack
            Console.WriteLine($"{lastStackItem} popped");

            Console.WriteLine($"the top of the stack is: {myStack.Peek()}");

            /*while(myStack.Count > 0)
            {
                Console.WriteLine($"The top value {myStack.Pop()} was removed from the stack");
                Console.WriteLine($"There are {myStack.Count} items left in the stack");
            }*/

            Console.WriteLine($"the top of the stack is: {myStack.Peek()}");

            Console.WriteLine("---------------");

            //TEST - reverse an array

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Stack<int> numbersStack = new Stack<int>();

            foreach(int num in numbers)
            {
                Console.WriteLine($"{num} has been added to the stack");
                numbersStack.Push(num);
            }

            Console.WriteLine(" ");
            Console.WriteLine("The numbers in reverse are:");
            while(numbersStack.Count > 0)
            {
                Console.WriteLine($"{numbersStack.Pop()}");
            }

            Console.ReadKey();
            //LAST IN FIRST OUT
        }
    }
}
