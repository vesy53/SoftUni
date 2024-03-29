﻿namespace NeedForSpeed.Vehicles.Motorcycles
{
    public class CrossMotorcycle : Motorcycle
    {
        public CrossMotorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption
             => base.FuelConsumption;

        public override void Drive(double kilometers)
        {
            base.Drive(kilometers);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
