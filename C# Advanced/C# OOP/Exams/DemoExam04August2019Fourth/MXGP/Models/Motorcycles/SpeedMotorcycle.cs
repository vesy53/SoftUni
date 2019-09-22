using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public class SpeedMotorcycle : Motorcycle
    {
        //The cubic centimeters for this type of motorcycle are 125. Minimum horsepower is 50 and maximum horsepower is 69.
        // If you receive horsepower which is not in the given range throw ArgumentException with message "Invalid horse power: {horsepower}.".

        private int horsePower;

        public SpeedMotorcycle(string model, int horsePower) 
            : base(model, horsePower, 125)
        {
        }

        public override int HorsePower
        {
            get => this.horsePower;
            protected set
            {
                if (value < 50 || value > 69)
                {
                    throw new ArgumentException(
                        $"Invalid horse power: {value}.");
                }

                this.horsePower = value;
            }
        }

    }
}
