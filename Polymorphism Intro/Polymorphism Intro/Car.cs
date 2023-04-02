using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Intro
{
    internal class Car
    {
        public int Horsepower { get; set; }
        public string Colour { get; set; }

        // Has a relationship
        protected CarInfo carStuff = new CarInfo();

        public void SetCarInfo(int id, string ownerName)
        {
            carStuff.IDNum = id;
            carStuff.OwnerName = ownerName;
        }
        
        public void GetCarInfo()
        {
            Console.WriteLine($"Car ID #{carStuff.IDNum} --- Current Owner {carStuff.OwnerName}");
        }


        public Car(int hp, string colour)
        {
            this.Horsepower = hp;
            this.Colour = colour;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"This car has {Horsepower}HP and is {Colour}");
        }

        public void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }

    }
}
