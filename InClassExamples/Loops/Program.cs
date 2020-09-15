using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add all of the values up from 1 to 100 and output the sum

            int sum = 0;
            // control var condition   incrementation/decrementation
            for (int i = 0; i < 101; i++)
            {

                sum = sum + i;
            }
            
            Console.WriteLine($"The sum of the values from 1- 100 is {sum}.");

            //ask the user if they want to perform another interation until they say no

            //int iterations = 1;
            //Console.WriteLine("Do you want to perform another iteration, yes or no?");
            //string response = Console.ReadLine();

            int iterations = 0;
            string response;

            do
            {
                iterations += 1;
                Console.WriteLine("Do you want to perform another iteration, yes or no?");
                response = Console.ReadLine();

            } while (response.ToLower() == "yes");

            //while (response.ToLower() == "yes")
            //{
            //    iterations += 1;
            //    Console.WriteLine("Do you want to perform another iteration, yes or no?");
            //    response = Console.ReadLine();
            //}

            Console.WriteLine($"The number of iterations (or times we asked the user) was {iterations}.");

            Console.ReadKey(); // Waiting for the user to press a key to exit
        }
    }
}
