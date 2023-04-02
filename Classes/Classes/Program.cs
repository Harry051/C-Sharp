using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //first create a new object of our class
            Human harry = new Human();

            //can access PUBLIC variables from outside and even change them
            harry.firstName = "Harry";
            harry.height = 192;

            //can call methods of the class as well
            harry.IntroduceMyself();

            Human lucy = new Human();
            lucy.firstName = "Lucy";
            lucy.lastName = "Jones";
            lucy.height = 170;
            lucy.IntroduceMyself();


            //based on how we used constructors can also make new objects with less lines of code!
            //we asked in Class for it to be formatted as Car(carManufacturer, carColour, carTopSpeed)
            Car fto = new Car("Mitsubishi", "Yellow", 125);
            fto.CarInfo();


            // again can change other variables like before
            Car defender = new Car("Land Rover", "Green", 87);
            defender.horsePower = 106;
            defender.hasRadio = false;
            defender.CarInfo();

            Car defaultEntry = new Car();
            defaultEntry.CarInfo();

            Console.Read();
        }
    }
}
