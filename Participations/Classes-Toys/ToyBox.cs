﻿using System;
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
            Toys = new List<Toy>();    
        }

        public Toy GetRandomToy( )
        {
            Random rnd = new Random();
            int randomToy = rnd.Next(Toy(i));

            return;
        }
    }
}
