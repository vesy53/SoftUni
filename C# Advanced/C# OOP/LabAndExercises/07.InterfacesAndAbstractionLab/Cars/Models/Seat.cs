namespace Cars.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Contracts;

    public class Seat : ICar
    {
        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model { get; private set; }

        public string Color { get; private set; }

        public string Start()
        {
            string result = "Engine start";

            return result;
        }

        public string Stop()
        {
            string result = "Breaaak!";

            return result;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine($"{this.Color} Seat {this.Model}")
                .AppendLine($"{this.Start()}")
                .Append($"{this.Stop()}");

            return builder.ToString();
        }
    }
}
