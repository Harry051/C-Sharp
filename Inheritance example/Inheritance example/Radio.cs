using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_example       //Could rewrite code but quite a waste of time. Check out Television Class ;)
{
    internal class Radio
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public Radio(bool isOn, string brand)
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
        
        public void ListenToRadio()
        {
            if(IsOn)
            {
                Console.WriteLine("I'M IN LOOOOOOOOOOVE WITH THE SHAPE OF YOOOOOOOU");
            }
            else
            {
                Console.WriteLine("Radio is currently off, please turn on");
            }
        }
    }
}
