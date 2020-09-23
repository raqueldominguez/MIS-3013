using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(s1);
            
            Console.WriteLine("What word do you want to look for in the above sentence?");
            char word = Console.ReadKey();

            Console.WriteLine("What word do you want to it to?");
            char word2 = Console.ReadKey();

            Console.ReadKey();
        }
    }
}
