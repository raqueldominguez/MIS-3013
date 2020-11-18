using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Classes_Toys
{
    class ToyBox
    {
        public List<Toy> Toys { get; set; }

        public ToyBox()
        {
            Toys= new List<Toy>();    
        }

        public Toy GetRandomToy()
        {
            Toy[] toyArray = Toys.ToArray();

            Random rnd = new Random();
            int randomToy = rnd.Next(0, Toys.Count + 1);
            int i = 0;
            Console.WriteLine(Toys[i]);

            return;
        }
    }
}
