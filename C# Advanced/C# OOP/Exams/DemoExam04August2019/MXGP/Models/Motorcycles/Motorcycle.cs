namespace MXGP.Models.Motorcycles
{
    using System;

    using MXGP.Models.Motorcycles.Contracts;

    public abstract class Motorcycle : IMotorcycle
    {
        private string model;

        protected Motorcycle(string model, int horsePower, double cubicCentimeters)
        {
            this.Model = model;
            this.HorsePower = horsePower;
            this.CubicCentimeters = cubicCentimeters;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value) ||
                    value.Length < 4)
                {
                    throw new ArgumentException(
                    $"Model {value} cannot be less than 4 symbols.");
                }

                this.model = value;
            }
        }

        // TODO
        public abstract int HorsePower { get; protected set; }
        
        public double CubicCentimeters { get; private set; }

        public double CalculateRacePoints(int laps)
        {
            return this.CubicCentimeters / HorsePower * laps;
        }
    }
}
