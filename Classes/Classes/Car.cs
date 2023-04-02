using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Car
    {
        //member variables
        public string manufacturer;
        private string colour;
        private int topSpeed;       //can set to private if being declared within constructor params. as can be changed
        public int horsePower;      //in the main program code
        public bool hasRadio = true;


        //Constructors are a faster way of creating new objects of a class

        //Constructors


        //Default constructor
        public Car()
        {
            Console.WriteLine("Constructor called, blank car object created");
        }

        //Parameterized constructor
        public Car(string carManufacturer, string carColour, int carTopSpeed)
        {
            manufacturer = carManufacturer;     // declare member variable and then assign it to local variable(arguments)
            this.topSpeed= carTopSpeed;         // Can use 'this' keyword too
        }
        //firstly when calling constructor, no static or void needed.

        //As we can see can have multiple constructors to include/exclude different bits of info as needed




        public void CarInfo()
        {
            Console.WriteLine($"Make: {manufacturer}\nColour: {colour}\nTop Speed: {topSpeed} mph\nHorsepower: {horsePower} bhp\nRadio Installed?: {hasRadio}");
        }

    }
}
