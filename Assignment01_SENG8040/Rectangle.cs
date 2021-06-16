using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01_SENG8040
{
    class Rectangle
    {
        private int length;
        private int width;

        // default Constructure
        public Rectangle()
        {
            length = 1;
            width = 1;
        }
        // User input constructor
        public Rectangle(int l, int w)
        {
            length = l;
            width = w;
        }
        public int GetLength()
        {
            return length;
        }
        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }
        public int GetWidth()
        {
            return width;
        }
        public int SetWidht(int width)
        {
            this.width = width;
            return this.width;
        }
        public int GetPerimeter()
        {
            return (2 * (length + width));
        }
        public int GetArea()
        {
            return (length * width);
        }


    }
}
