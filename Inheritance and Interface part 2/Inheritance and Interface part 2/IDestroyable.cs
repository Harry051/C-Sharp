using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Interface_part_2
{
    // When namming an interface use a capital 'I' in front of whatever you want to call it.
    internal interface IDestroyable
    {
        // Property to store audio file of destruction sound
        string DestructionSound { get; set; }

        // Method to destroy an object
        void Destroy();
    }
}
