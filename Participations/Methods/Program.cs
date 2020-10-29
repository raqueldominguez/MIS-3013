using System;
using System.Xml;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an animal.");
            string animal = Console.ReadLine();
            string animalSound = speak(animal);
            Console.WriteLine(animalSound);
            Console.ReadKey();
        }

            static string speak(string animal)
            {
                
                string animalSound;

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
                else
                {
                    animalSound = "Could not find an animal.";
                }           
                return animalSound;

            //string output = "";

            //switch (animal.ToLower())
            //{
            //    case "dog":
            //        output = "ruff";
            //        break;
            //    case "monkey":               
            //        output = "ooo ah ah";
            //        break;
            //    case "goat":
            //        output = "bah";
            //        break;
            //    default:
            //        output = "Sorry I do not recognize the animal of " + animal + ".";
            //        break;
            //}
        }                  
    }
}
