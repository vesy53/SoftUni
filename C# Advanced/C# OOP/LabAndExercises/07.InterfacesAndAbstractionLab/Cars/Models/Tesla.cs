namespace Cars.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Contracts;

    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }

        public string Model { get; private set; }

        public string Color { get; private set; }

        public int Battery { get; private set; }

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
                .AppendLine($"{this.Color} Tesla {this.Model} with {this.Battery} Batteries")
                .AppendLine($"{this.Start()}")
                .Append($"{this.Stop()}");

            return builder.ToString();
        }
    }
}
