using System;

namespace IEnumerator_and_IEnumerable
{
    internal class Program
    {
        // 1. IEnumerable <T> for generic collections
        // 2. IEnumerable for non generic collections

        /// <summary>
        /// IEnumerable<T> contains a single method that you must implement when implementing this interface;
        /// GetEnumerator(), a method which return an IEnumertator<T> object.
        /// The returned IEnumerator<T> provides the ability to iterate through all objects within the collection.
        /// It exposes a Current property that points at the object we are currently at in the collection.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            DogHome batterseaHome = new DogHome();
            foreach(Dog doggy in batterseaHome)
            {
                if(!doggy.IsNaughtyDog)
                {
                    doggy.GiveTreat(2);
                }
                else
                {
                    doggy.GiveTreat(1);
                }
            }

        }
    }
}
//IEnumrable interface Recommended for:
// 1. When you have a MASSIVE database, and copying would cause memory issues

//IEnumerable NOT recommended for:
//1. When need results IMMEDIATLY
//2. If you want to mutate or change results in anyway. --> for this better to use Arrays or Lists.
