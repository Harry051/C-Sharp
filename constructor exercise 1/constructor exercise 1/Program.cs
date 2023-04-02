using System;

namespace constructor_exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human harry = new Human("Harry", "Smith", "Blue", 28);
            Human keith = new Human("Keith", "Chegwin", "Brown", 58);
            Human anna = new Human("Anna", "Sarowski");
            Human neil = new Human("Neil");

            harry.SayHello();
            keith.SayHello();
            anna.SayHello();
            neil.SayHello();

        }
    }
}
