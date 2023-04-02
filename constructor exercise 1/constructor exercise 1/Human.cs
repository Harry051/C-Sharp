using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_exercise_1
{
    internal class Human
    {
        public string firstName;
        public string lastName;
        public string eyeColour;
        public int age;

        public Human(string firstName, string lastName, string eyeColour, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColour = eyeColour;
            this.age = age;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public void SayHello()
        {
            if(age == 0)
            {
                Console.WriteLine($"Hi there! I'm {firstName} {lastName}.");
            }
            else if(lastName == "")
            {
                Console.WriteLine($"Hi there! I'm {firstName}.");
            }
            else
            {
                Console.WriteLine($"Hi there! I'm {firstName} {lastName}. My eyes are {eyeColour} and I'm {age} years old.");
            }
        }
    }
}
