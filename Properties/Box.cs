using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Box
    {
        
        // member variable
        private int length = 3;
        private int height;
        //public int width;
        private int volume;

        public int Width { get; set; }
       
        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }
        }


        /*
        public int width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }
        */

        public int Height
        {
            get { return height; }
            set 
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
            
        }

        public void Setlength(int length)
        {
            if(length < 0)
            {
                throw new Exception("length must be higher than 0");
            }
            this.length = length;
        }

        public int Getlength()
        {
            return length;
        }

        /*public int Getvolume()
        {
            return this.length * this.height * this.Width;
        }*/

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} height is {1} width is {2} and volume is {3}",
                length,height,Width,volume = length * height * Width);
        }
    }
}
