namespace MXGP.Models.Motorcycles
{
    using System;

    public class PowerMotorcycle : Motorcycle
    {
        //The cubic centimeters for this type of motorcycle are 450. Minimum horsepower is 70 and maximum horsepower is 100.
 
        private const double PowerCubicCentimeters = 450;
        private const int MinHorsepower = 70;
        private const int MaxHorsepower = 100;

        private int horsePower;

        public PowerMotorcycle(string model, int horsePower) 
            : base(model, horsePower, PowerCubicCentimeters)
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
