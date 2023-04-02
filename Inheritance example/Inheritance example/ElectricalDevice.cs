using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_example
{
    internal class ElectricalDevice     //Parent/Base class
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }


        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }

        public void UseDevice()
        {
            if (IsOn == true)
            {
                Console.WriteLine("Enjoy your device's content :)");
            }
            else
            {
                Console.WriteLine("Device is currently off, please turn on to use it");
            }
        }

    }
}
