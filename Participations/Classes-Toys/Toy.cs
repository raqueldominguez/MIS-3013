﻿using System;

namespace Classes_Toys
{
    public class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes { get; set; }

        public Toy()
        {

        }

        public string GetAisle()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 25);
            return GetAisle;
        }
    }
}