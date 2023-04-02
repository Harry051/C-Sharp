using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // This calss is a blueprint for a datatype
    internal class Human
    {
        // member variables
        public string firstName;    //If you don't put public you will be unable to change it later
        public int height;
        public string lastName = "Smith";   //Sets every last name to Smith upon creation. Will stay unless changed.
        private string homeTown = "London"; //As private will be not be able to change it in the Main method.


        //  member method
        public void IntroduceMyself()
        {
            Console.WriteLine($"Hi I'm {firstName} {lastName} and I'm {height}cm tall.");
        }

    }
}
