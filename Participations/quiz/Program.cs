using System;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 4; i > 0; i--)
            {
                Console.WriteLine("There are " + i + " puppies left.");
            }

            Console.ReadKey();
        }
    }
}

