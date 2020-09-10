using System;

namespace Conditional_CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Pick heads or tails");
            string answer = Console.ReadLine();
            const int HEADS = 0;
            const int TAILS = 1;

            Random rnd = new Random();
            int result = rnd.Next(0, 2);

            if (answer == "Heads")
            {
                answer = HEADS;
            }
            else if (answer == "Tails")
            {
                Console.WriteLine("Tails");
            }
            else 
            

            
	

	}

        }
    }
}
