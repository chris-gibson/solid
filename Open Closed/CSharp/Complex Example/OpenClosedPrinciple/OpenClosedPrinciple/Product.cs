﻿namespace VoilatingOpenClosedPrinciple
{
    internal class Product
    {
        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public int Id { get; set; }

        public double Price { get; set; }

        public override string ToString()
        {
            return Name + " " + Manufacturer;
        }
    }
}