namespace MXGP.Models.Motorcycles
{
    using System;

    using Contracts;
    using MXGP.Utilities.Messages;

    public abstract class Motorcycle : IMotorcycle
    {
        private const int DefaultStringLength = 4;

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
                    value.Length < DefaultStringLength)
                {
                    throw new ArgumentException(
                        string.Format(
                            ExceptionMessages.InvalidModel,
                            value, DefaultStringLength));
                }

                this.model = value;
            }
        }

        public virtual int HorsePower { get; protected set; }

        public double CubicCentimeters { get; private set; }

        public double CalculateRacePoints(int laps)
        {
            return this.CubicCentimeters / this.HorsePower * laps;
        }
    }
}
