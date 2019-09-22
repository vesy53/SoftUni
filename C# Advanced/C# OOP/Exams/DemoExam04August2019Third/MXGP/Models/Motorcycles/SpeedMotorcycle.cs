namespace MXGP.Models.Motorcycles
{
    using System;

    using MXGP.Utilities.Messages;

    public class SpeedMotorcycle : Motorcycle
    {
        //The cubic centimeters for this type of motorcycle are 125. 
        //Minimum horsepower is 50 and maximum horsepower is 69.

        private const double DefaultCubicCentimeters = 125;
        private const int MinValue = 50;
        private const int MaxValue = 69;

        private int horsePower;

        public SpeedMotorcycle(string model, int horsePower)
            : base(model, horsePower, DefaultCubicCentimeters)
        {
        }

        public override int HorsePower
        {
            get
            {
                return this.horsePower;
            }

            protected set
            {
                if (value < MinValue ||
                    value > MaxValue)
                {
                    throw new ArgumentException(
                        string.Format(
                            ExceptionMessages.InvalidHorsePower,
                            value));
                }

                this.horsePower = value;
            }
        }
    }
}