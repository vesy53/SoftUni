namespace p03._01.WildFarm.Models.Foods
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Contracts;

    public abstract class Food : IFood
    {
        public Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; private set; }

        public override string ToString()
        {
            return "";
        }
    }
}
