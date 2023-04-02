using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_part_2
{
    internal class Car : Vehicle, IDestroyable
    {
        // Need to implement the interfaces properties or it WONT WORK
        public string DestructionSound { get; set; }

        /*
         * Need to create a new property to store destroyable objects nearby
         * when a car gets destroyed it should also destroy a nearby object
         * List is of tupe IDestroyable - means it can store any object that implements this interface
         * And we can only access the properties and methods within this inteface
         */

        public List<IDestroyable> DestroyablesNearby;

        public Car(float speed, string colour)
        {
            this.Speed = speed;
            this.Colour = colour;
            // Need to initialize the interfaces property with a value in the constructor
            DestructionSound = "CarExplosionNoise.MP3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        public void Destroy()
        {
            //When Car is destroyed should play destruction sound and make a fire effect
            Console.WriteLine($"Playing the Destruction sound: {DestructionSound}");
            Console.WriteLine("Creating fire");

            //Go through each destroyable object nearby and call it's destroy method
            foreach (IDestroyable destroyableObject in DestroyablesNearby)
            {
                destroyableObject.Destroy();
            }
        }
    }
}
