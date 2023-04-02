using System;
using System.Collections.Generic;

namespace Polymorphism_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //As parent/child classes no casting needed.
            //can use "BMW" or "Audi" wherever car is expected :)
            var cars = new List<Car>
            {
                new Audi(200, "green", "A6"),
                new BMW(220, "silver", "Z4")
            };


            //Can see it uses the methods from the child classes instead of the parent one
            //Because we used VIRTUAL and OVERRIDE keywords
            //Polymorphism shows we can change the meaning of things between classes.
            foreach (var car in cars)
            {
                car.ShowDetails();
            }


            Car audiQuattro = new Audi(150, "red", "Quattro");
            Audi audiTT = new Audi(170, "blue", "TT");

            //Can see here the difference in new and override.
            //The quattro was made as a Car object(therefore new method isn't overriden) and uses the parent method.
            //The TT is an Audi object directly, therefore the priority method takes effect.


            audiQuattro.Repair();
            audiTT.Repair();

            //Essentially new is saying if you create an object of my class, use my new marked method
            //      otherwise will revert to the parent
            //(Basically can make a one off exception instead of a broad thing like virtual/override combo.

            Car car1 = (Car)audiTT;
            car1.Repair();
            //Allows us to make a new variable that has been CASTED into the car object. Therefore the parent
            //rule applies to this one specific variable of car.


            audiQuattro.SetCarInfo(10, "Gene Hunt");
            audiTT.SetCarInfo(11, "Mick Schumacher");
            audiQuattro.GetCarInfo();
            audiTT.GetCarInfo();
            //Using the 'Has A' relationship can set new values through the classes

            Console.ReadKey();
        }
    }
}
