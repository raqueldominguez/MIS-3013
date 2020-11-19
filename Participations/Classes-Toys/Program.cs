using System;
using System.Collections.Generic;

namespace Classes_Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            ToyBox livingRoomToyBox = new ToyBox();
            ToyBox playRoomToyBox = new ToyBox();

            Toy TeddyBear = new Toy();
            TeddyBear.Manufacturer = "Hasbro";
            TeddyBear.Name = "Teddy Ruxpin";
            TeddyBear.Price = 49.99;
            //TeddyBear.Notes !!!This is private so we cannot access it from this class

            Toy lego1 = new Toy("Lego", "Star Wars Ship", 39.99, "Not for kids under 5 because they could choke.");
            Toy lego2 = new Toy("Lego", "Star Wars Ship", 39.99, "Not for kids under 5 because they could choke.");
            Toy lego3 = new Toy("Lego", "Star Wars Ship", 39.99, "Not for kids under 5 because they could choke.");

            livingRoomToyBox.Toys.Add(TeddyBear);
            livingRoomToyBox.Toys.Add(lego1);

            playRoomToyBox.Toys.Add(lego2);
            playRoomToyBox.Toys.Add(lego3);

            Toy rando = livingRoomToyBox.GetRandomToy();
            //Console.WriteLine($"{rando.Manufacturer} makes {rando.Name} and sells it for {rando.Price.ToString("C2")}.");
            rando = playRoomToyBox.GetRandomToy();
            Console.WriteLine(rando);


            Console.ReadKey();
        }
    }
}
