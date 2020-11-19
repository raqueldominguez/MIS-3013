using System;

namespace Classes_Toys
{
    public class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes;

        public Toy()
        {
            //constructor
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Notes = string.Empty;
        }

        public Toy(string notes)
        {
            //this gives us options from which constructor to use
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Notes = notes;
        }

        public Toy(string manufactuerer, string name, double price, string notes)
        {
            Manufacturer = manufactuerer;
            Name = name;
            Price = price;
            Notes = notes;
        }

        public string GetAisle()
        {
            //method
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 25);
            char manufacturerLetter = Manufacturer[0];
            string aisle = $"{manufacturerLetter}" + $"{randomNumber}";
            return aisle;
        }

        public override string ToString()
        {
            return $"{Manufacturer} makes {Name} and sells it for {Price.ToString("C2")}." + "\n" + Notes;
        }
    }
}