using System;
using System.Collections; // Needs to be said as ArrayList class is within the Collections class

namespace Array_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // An array list doesn't have to store one datatype, ie string or integer but can store any type of object


            //declaring an Array List
            ArrayList myArrayList = new ArrayList();

            //Can set how many objects shouold be in there
            ArrayList myArrayList2 = new ArrayList(100);

            //This adds things into the array list
            myArrayList.Add(1);
            myArrayList.Add("Hello");
            myArrayList.Add(17.238);
            myArrayList.Add('£');
            myArrayList.Add(98);
            myArrayList.Add(98);
            myArrayList.Add(123.743);
            myArrayList.Add(72);
            

            //This removes an entry with a specific value from the array list
            myArrayList.Remove(98);

            //This removes an element via its index
            myArrayList.RemoveAt(0);

            int numOfEntries = myArrayList.Count;
            Console.WriteLine($"There are {numOfEntries} things in this list");

            foreach (object item in myArrayList)
                Console.WriteLine(item);


            //If wanted to add all elements within the list would write code like this:

            double sum = 0;

            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj); // <-- need to convert as can't add doubles with ints
                }
                else if (obj is double)
                {
                    sum += (double)obj; // can't simply add objects together so need to cast the value into a double datatype
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
