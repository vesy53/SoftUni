namespace MXGP.Models.Motorcycles
{
    using System;

    using MXGP.Utilities.Messages;

    public class SpeedMotorcycle : Motorcycle
    {
        //The cubic centimeters for this type of motorcycle are 125. Minimum horsepower is 50 and maximum horsepower is 69.

        private const double DefaultCubicCentimeters = 125;
        private const double MinHorsePower = 50;
        private const double MaxHorsePower = 69;

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
                //If you receive horsepower which is not in the given range 
                //throw ArgumentException with message "Invalid horse power: {horsepower}.".

                if (value < MinHorsePower ||
                    value > MaxHorsePower)
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
