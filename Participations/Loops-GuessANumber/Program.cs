using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerValue;
            int upperValue;
            int userGuess;

            Console.WriteLine("Pick a minimum number.");
            lowerValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a maximum number");
            upperValue = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int randomNumber = rnd.Next(lowerValue, upperValue + 1);

            do
            {
                Console.WriteLine("Enter your guess for the random number.");
                userGuess = Convert.ToInt32(Console.ReadLine());
               
                if (userGuess > upperValue || userGuess< lowerValue)
                {
                    Console.WriteLine("Sorry your number is outside the range. Try again.");
                }
            } while (userGuess != randomNumber);
            Console.WriteLine("Congratulations, that is the correct guess!");
           
            
            Console.ReadKey();
        }
    }
}
