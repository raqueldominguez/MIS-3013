using System;
using System.Net;
using System.Text;
using System.Xml;

namespace Participation_SumOf3

{
    class Program
    {
        const double LUCKY_NUMBER = 7.777;
           
        static void Main(string[] args)

        {
            double first, second, third, sum;

            Console.WriteLine("Enter a first number. >>");
            string input = (Console.ReadLine());
            first = Convert.ToDouble(input);

            Console.WriteLine("Enter a second number. >>");
            second = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a third number. >>");
            third = Convert.ToDouble(Console.ReadLine());

            sum = first + second + third;
            Console.WriteLine($"The sum of the three numbers is: " + sum.ToString("N3"));

            double luckyNum = sum * LUCKY_NUMBER;

            Console.WriteLine($"The sum multiplied by 7.777 is: {luckyNum.ToString ("N3")}.");
        }
    }
}
