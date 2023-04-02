using System;
using System.Collections.Generic;

namespace Delegates_part_2
{
    internal class Program
    {
        //making a delegate that takes a Person object and returns a bool
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            Person p1 = new Person("Nick", 32, "Male");
            Person p2 = new Person("Georgia", 23, "Female");
            Person p3 = new Person("Sid", 25, "Female");
            Person p4 = new Person("Sam", 52, "Male");

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Older than 30:", people, OverThirty);
            DisplayPeople("The Boys:", people, IsBoy);
            DisplayPeople("The Girls:", people, IsGirl);

            //Here we created a new variable called myFilter of type FilterDelegate.
            //Then we assigned an anonymous method to it instead of an already defined method.

            FilterDelegate myFilter = delegate (Person p)
            {
                return p.Age >= 25 && p.Age <= 35;
            };

            //Can use it here as saved the anon method to type FilterDelegate, so works as a param
            DisplayPeople("Inbetweeners:", people, myFilter);


            //Can also use the anonymous method DIRECTLY in the Params
            //Leaves quite a condensed line of code though.
            DisplayPeople("All: ", people, delegate (Person p) { return true; });


            //LAMBDA EXPRESSIONS

            // Delcared using the => operand
            // Essentially a lambda is just a short block of code that accepts parameters and returns a value 

            //This is a statement lambda
            string searchKeyword = "a";
            DisplayPeople("People under 30 with an 'a' in their name:", people, (p) =>
            {
                if (p.Name.Contains(searchKeyword) && p.Age < 30)
                {  
                    return true;
                }
                else
                {
                    return false;
                }
            });

            //This is an expression lambda (one line of code)
            DisplayPeople("People who are exactly 32:", people, p => p.Age == 32);


           
        }





        //A method to display the list of people that pass the filter condition
        //(is true)
        //This method will take a title to be displayed, the list of people and a filter delegate.

        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach(Person p in people)
            {
                //check if this person passes the filter
                if(filter(p))
                {
                    Console.WriteLine($"{p.Name}, {p.Age} years old");

                }
            }

        }

        //-----FILTERS------
        static bool OverThirty(Person p)
        {
            if (p.Age > 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsBoy(Person p)
        {
            if (p.Gender == "Male")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsGirl(Person p)
        {
            if(p.Gender == "Female")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
