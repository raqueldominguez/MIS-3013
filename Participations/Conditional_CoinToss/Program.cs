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
            Console.WriteLine("Enter Heads or Tails >>");
            string usersGuessAsString = Console.ReadLine();
            int usersGuess;
            const int HEADS = 0;
            const int TAILS = 1;

            if (usersGuessAsString == "Heads")
            {
                usersGuess = HEADS;
            }
            else if (usersGuessAsString == "Tails")
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
                Console.WriteLine($"Congrats, {usersGuessAsString} was right!");
            }
            else
            {
                if (usersGuess == 0)
                {
                    Console.WriteLine($"Sorry, Tails was the correct answer and you guessed {usersGuessAsString}  =(");
                    //"Sorry, Tails was the correct answer and you guessed " + usersGuessAsString + "  =(");
                }
                else
                {
                    Console.WriteLine($"Sorry, Heads was the correct answer and you guessed {usersGuessAsString}  =(");
                }
            }

            Console.ReadKey(); //Prevent the application from closing until we press a key


	

        }
    }
}   
