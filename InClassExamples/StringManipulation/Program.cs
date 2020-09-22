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
            //                         012345678910 
            String instanceOfString = "Hello World!";

            instanceOfString = instanceOfString.ToUpper();
            for (int i = 0; i < instanceOfString.Length; i++)
            {
                char letter = instanceOfString[i];
                // Have to convert the CHARACTER to a string to use the string methods
                Console.WriteLine(letter);//.ToString().ToUpper());
            }

            Console.ReadKey();
        }
        
    }
}
