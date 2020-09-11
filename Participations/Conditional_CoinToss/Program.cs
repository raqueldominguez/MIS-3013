using System;

namespace Conditional_CoinToss
{
    class Program
    {
        const string DEVELOPER = "Raquel Dominguez";
        static void Main(string[] args)
        {          
            Console.WriteLine("Pick heads or tails >>");
            string answer = Console.ReadLine();
            int guess;
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 2);
            Console.WriteLine(randomNumber);
            const int HEADS = 0;
            const int TAILS = 1;

            if (answer == "heads")
            {
                guess = HEADS;
            }
            else if (answer == "tails")
            {
                guess = TAILS;
            }
            else
            {
                Console.WriteLine("Invalid entry: Try again");
                return;
            }



            if (guess == randomNumber)
            {
                Console.WriteLine($"Congrats, {answer} was right!");
            }
            else
            {
                if (guess == 0)
                {
                    Console.WriteLine($"Sorry, Tails was the correct answer and you guessed {answer}");
                }
                else
                {
                    Console.WriteLine($"Sorry, Heads was the correct answer and you guessed {answer}");
                }
            }

            Console.WriteLine(DEVELOPER);
            Console.ReadKey(); 


	

        }
    }
}   
