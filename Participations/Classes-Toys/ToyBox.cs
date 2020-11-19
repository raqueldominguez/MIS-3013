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
            //constructor
            Toys= new List<Toy>();    
        }

        public Toy GetRandomToy()
        {
            //method

            Random rnd = new Random();
            int index = rnd.Next(0, Toys.Count);

            Toy randomToy = Toys[index];

            return randomToy;
        }
    }
}
