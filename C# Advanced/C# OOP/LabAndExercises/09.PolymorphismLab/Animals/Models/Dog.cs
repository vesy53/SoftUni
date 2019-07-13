﻿namespace Animals.Models
{
    using System.Text;

    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) 
            : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine(base.ExplainSelf())
                .Append("DJAAF");

            return builder.ToString();
        }
    }
}
