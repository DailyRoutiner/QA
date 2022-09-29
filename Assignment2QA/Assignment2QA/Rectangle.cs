using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2QA
{
    public class Rectangle
    {
        int width;
        int length;

        public Rectangle()
        {
            this.width = 1; this.length = 1;
        }

        public Rectangle(int width, int length)
        {
            this.width = width;
            this.length = length;
        }

        public int GetCurrentLength()
        {
            return this.length;
        }
        public int SetNewLength(int length) { 
            return this.length = length;
        }

        public int GetCurrentWidth() { 
            return this.width;
        }
        public int SetNewWidth(int width) { 
            return this.width = width;
        }
        public int GetPerimeter() {
            return 2 * (width + length);
        }
        public int GetArea() {
            return width * length;
        }


    }
}
