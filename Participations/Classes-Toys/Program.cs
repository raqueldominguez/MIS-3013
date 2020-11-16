using System;

namespace Classes_Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            ToyBox MyToyBox = new ToyBox();
            randomNumber = MyToyBox;

            string answer;
            do
            {
                Console.WriteLine("Do you want to add a toy to the toy box?");
                answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                {
                    Console.WriteLine("What toy do you want to add?");
                    string toy = Console.ReadLine();
                    ToyBox.Add(toy);
                }

            } while (answer == "yes");

            Console.ReadKey();
        }
    }
}
