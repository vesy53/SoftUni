namespace MXGP.Models.Motorcycles
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SpeedMotorcycle : Motorcycle
    {
        //The cubic centimeters for this type of motorcycle are 125. Minimum horsepower is 50 and maximum horsepower is 69.

        private const double SpeedCubicCentimeters = 125;
        private const int MinHorsepower = 50;
        private const int MaxHorsepower = 69;

        private int horsePower;

        public SpeedMotorcycle(string model, int horsePower)
            : base(model, horsePower, SpeedCubicCentimeters)
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
                //If you receive horsepower which is not in the given range throw 
                // ArgumentException with message "Invalid horse power: {horsepower}.".
                if (value < MinHorsepower || value > MaxHorsepower)
                {
                    throw new ArgumentException(
                        $"Invalid horse power: {value}.");
                }

                this.horsePower = value;
            }
        }
    }
}
