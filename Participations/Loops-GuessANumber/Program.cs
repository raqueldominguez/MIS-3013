using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int min;
            int max;
            Random rnd = new Random();
            int randomNumber = rnd.Next(min,max);

            Console.WriteLine("Pick a minimum number.");
            Console.ReadLine();
            Console.WriteLine("Pick a maximum number");
            Console.ReadLine();

        }
    }
}
