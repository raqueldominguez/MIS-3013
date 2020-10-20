using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an animal.");
            string animal = Console.ReadLine();

            static string speak (string animal)
            {
                if (animal == "dog")
                {
                    Console.WriteLine("woof");
                }
                else if (animal == "monkey")
                {
                    Console.WriteLine("oo ah ah");
                }
                else if (animal == "goat")
                {
                    Console.WriteLine("bahhh");
                }
            }


            Console.ReadKey();
        }
    }
}
