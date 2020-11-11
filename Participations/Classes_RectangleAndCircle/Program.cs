using System;

namespace Classes_RectangleAndCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle();
            myCircle.Radius = 7.5;
            Console.WriteLine($"The area of a circle with a radius of {myCircle.Radius} is {myCircle.CalculateArea()}\n" +
                                $" and a perimeter of {myCircle.CalculatePerimeter()}.");

            Circle circle2 = new Circle();
            circle2.Radius = 82828282;
            double areaOfCircle2 = circle2.CalculateArea();
            double perimeterOfCircle2 = circle2.CalculatePerimeter();

            Circle circle3 = new Circle(3.5);


            Rectangle myRectangle = new Rectangle();
            myRectangle.Length = 4;
            myRectangle.Width = 8;
            Console.WriteLine($"The area of a rectangle with length of {myRectangle.Length} and width of {myRectangle.Width} is {myRectangle.CalculateArea()}\n" +
                                $" and a perimeter of {myRectangle.CalculatePerimeter()}.");

            Console.ReadKey();
        }
    }
}
