using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Box
    {
        //member variables
        private int length;
        private int height;
        //public int width;

        
        // In order to SET a private member variable need to make a MEMBER METHOD within the class.
        public void SetLength(int num)
        {
            if (num < 0)
            {
                throw new Exception("Length can not be a negative number");
            }
            this.length = num;
            
        }
        
        // A GET method is good if you need to read the variable from outside this class
        public int GetLength()
        {
            return this.length;
        }


        // Above way is a bit more time consuming
        // Proper notation should look like below.

        public int Height       //convention for method name to be same as the variable but CAPITALISED
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value; //value is a keyword in C#. knows to set height to its assigned value in main block.
            }
        }

        // A third way of doing this. Is a shortcut for above method
        // creates a DEFAULT get set property. Means can't tweak it with if/elses and exceptions like above model
        // Using this shortcut no longer need to declare variable as automatically done.
        public int Width { get; set; }

        public Box(int l, int h, int w)
        {
            this.length = l;
            this.height = h;
            this.Width = w;
        }


        public void DisplayInfo()
        {
            int result = length * height * Width;
            Console.WriteLine($"The volume of your box is {result}");
        }

        
    }
}
