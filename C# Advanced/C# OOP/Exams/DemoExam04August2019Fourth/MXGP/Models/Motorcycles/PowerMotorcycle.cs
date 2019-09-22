using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public class PowerMotorcycle : Motorcycle
    {
        //The cubic centimeters for this type of motorcycle are 450. Minimum horsepower is 70 and maximum horsepower is 100.
       // If you receive horsepower which is not in the given range throw ArgumentException with message "Invalid horse power: {horsepower}.".

       private int horsePower;

        public PowerMotorcycle(string model, int horsePower)
            : base(model, horsePower, 450)
        {
        }

        public override int HorsePower
        {
            get => this.horsePower;
            protected set
            {
                if (value < 70 || value > 100)
                {
                    throw new ArgumentException(
                        $"Invalid horse power: {value}.");
                }

                this.horsePower = value;
            }
        }
    }
}
