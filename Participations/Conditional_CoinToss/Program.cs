using System;

namespace Conditional_CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int randomNumber = rand.Next(0, 2);
            Console.WriteLine(randomNumber);
            Console.WriteLine("Pick Heads or Tails");
            string answer = Console.ReadLine();
            int usersGuess;
            const int HEADS = 0;
            const int TAILS = 1;

            if (answer == "Heads")
            {
                usersGuess = HEADS;
            }
            else if (answer == "Tails")
            {
                usersGuess = TAILS;
            }
            else
            {
                Console.WriteLine("Invalid entry: Please try again later");
                Console.ReadKey();
                return;
            }



            if (usersGuess == randomNumber)
            {
                Console.WriteLine($"Congrats, {answer} was right!");
            }
            else
            {
                if (usersGuess == 0)
                {
                    Console.WriteLine($"Sorry, Tails was the correct answer and you guessed {answer}");
                }
                else
                {
                    Console.WriteLine($"Sorry, Heads was the correct answer and you guessed {answer}");
                }
            }

            Console.ReadKey(); 


	

        }
    }
}   
