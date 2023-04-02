using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_example
{
    // : makes Television a child class of ElectricalDevice
    internal class Television : ElectricalDevice
    {
        public Television(bool isOn, string brand):base(isOn, brand)
        {
            //Can leave properties empty as using BASE keyword, it now inherits from ElectricalDevice class
        }
    }
}
