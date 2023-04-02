using System;

namespace Inheritance_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio dadsRadio = new Radio(true, "Phillips");
            Television myTelevision = new Television(false, "Samsung");
            myTelevision.SwitchOn();
            myTelevision.UseDevice();   //Using general inherited method from parent class
            dadsRadio.ListenToRadio();  // Using more specific method from child class

            Console.ReadKey();
        }
    }
}
