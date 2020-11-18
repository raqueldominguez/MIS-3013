using System;
using System.Collections.Generic;

namespace Classes_Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            ToyBox MyToyBox = new ToyBox();
            Toy MyToy = new Toy();

            ToyBox Toys = new List<Toy>();

            string answer;
            do
            {
                Console.WriteLine("Do you want to add a toy to the toy box?");
                answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                {
                    Console.WriteLine("What toy do you want to add?");
                    string newtoy = Console.ReadLine();
                    ToyBox.Toy.Add(newtoy);
                }

            } while (answer == "yes");


            Console.WriteLine("What is the manufacturer name?");
            MyToy.Manufacturer = Console.ReadLine();

            Console.WriteLine("What is the toy name?");
            MyToy.Name = Console.ReadLine();

            Console.WriteLine("What is the price?");
            MyToy.Price = Convert.ToDouble(Console.ReadLine());

            //int randomNumber = MyToyBox;

            MyToy.GetAisle();

            Console.ReadKey();
        }
    }
}
