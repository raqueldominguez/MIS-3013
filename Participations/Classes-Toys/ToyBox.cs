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
            Toys = new List<Toy>();    
        }

    }
}
