using System;

namespace Conditional_CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Pick heads or tails");
            Random rdn = new Random();
            int randomNumber = rdn.Next(0, 2);
            Console.WriteLine(randomNumber);
            int answer;
            string answer = Console.ReadLine();
            const int HEADS = 0;
            const int TAILS =1; 

            if (rdn.Next == 0)
                Console.WriteLine("Heads");
            else if (rdn.Next == 1)
                Console.WriteLine("Tails");
	{

	}
	{

	}
	{

	}

        }
    }
}
