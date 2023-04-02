using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_challange
{
    internal class Box
    {
        private int height;
        private int length;
        public int Width { get; set; }

        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
            }
        }

        public int Volume
        {
            get
            {
                return height * length * Width;
            }
        }

        public int FrontSurface
        {
            get
            {
                return height * length;
            }
        }
        public Box(int h, int l, int w)
        {
            this.height = h;
            this.length = l;
            this.Width = w;
        }

    }
}
