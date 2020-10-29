using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Rectangle
    {
        private int width;
        private int height;

        //this is the default/empty constructor for the class
        public Rectangle()
        {
            width = 0;
            height = 0;
        }

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public double Area()
        {
            double result = width * height;

            return result;
        }
    }
}
