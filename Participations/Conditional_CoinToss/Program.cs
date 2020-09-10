using System;

namespace Conditional_CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdn = new Random();
            int randomNumber = rdn.Next(0, 2);
            Console.WriteLine(randomNumber);
            Console.WriteLine("Pick heads or tails");
            string usersGuessAsString = Console.ReadLine();
            int usersGuess;
            const int HEADS = 0;
            const int TAILS =1; 

        }
    }
}
