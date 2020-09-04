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
            Console.WriteLine("Enter a first number.");
            int first = (int)Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Enter a second number.");
            int second = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a third number.");
            int third = (int)Convert.ToDouble(Console.ReadLine());

            int sum = (first + second + third);
            Console.WriteLine("The sum of the three numbers is: " + sum.ToString("F3"));

            Console.WriteLine("The sum multiplied by 7.777 is: " + (sum * LUCKY_NUMBER));
        }
    }
}
