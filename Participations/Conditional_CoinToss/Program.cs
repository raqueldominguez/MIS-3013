using System;

namespace Conditional_CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Pick heads or tails");
            string answer = Console.ReadLine();
            Random rnd = new Random();
            int result = rnd.Next(0, 2);
            const int HEADS_VALUE = 0;
            const int TAILS_VALUE = 1;

            if (result == 0)
            {
                Console.WriteLine("Heads");
            }
            else if (result == 1)
            {
                Console.WriteLine("Tails");
            }

           




            Console.ReadKey();

	}

        }
    }
}   
