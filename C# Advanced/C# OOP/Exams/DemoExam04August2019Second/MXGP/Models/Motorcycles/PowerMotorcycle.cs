﻿namespace MXGP.Models.Motorcycles
{
    using System;

    using MXGP.Utilities.Messages;

    public class PowerMotorcycle : Motorcycle
    {
        //The cubic centimeters for this type of motorcycle are 450. Minimum horsepower is 70 and maximum horsepower is 100.

        private const double DefaultCubicCentimeters = 450;
        private const double MinHorsePower = 70;
        private const double MaxHorsePower = 100;

        private int horsePower;

        public PowerMotorcycle(string model, int horsePower)
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