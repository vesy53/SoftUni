﻿namespace Restaurant.Products.Foods.Starters
{
    public class Soup : Starter
    {
        public Soup(string name, decimal price, double grams)
            : base(name, price, grams)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}