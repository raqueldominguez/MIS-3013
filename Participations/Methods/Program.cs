using System;

namespace Methods
{
    class Program
    {
        //static void Main(string[] args)
        
            
            static string speak(string animalType)
            {               
                Console.WriteLine("Please enter an animal.");
                string animal = Console.ReadLine();
                string animalSound = animalType;                

                if (animal == "dog")
                {
                    animalSound = "woof";
                }
                else if (animal == "monkey")
                {
                    animalSound = "oo ah ah";
                }
                else if (animal == "goat")
                {
                    animalSound = "bahhh";
                }
                return animalSound;

            Console.ReadKey();
            }

            
        
    }
}
