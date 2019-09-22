using System;

public abstract class Provider : Identifier
{
    private const int MinEnergyOutput = 0;
    private const int MaxEnergyOutput = 10000;

    private double energyOutput;

    protected Provider(string id, double energyOutput) 
        : base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public double EnergyOutput
    {
        get
        {
            return this.energyOutput;
        }

        protected set
        {
            ValidateEnergyOutput(value);

            this.energyOutput = value;
        }
    }

    private static void ValidateEnergyOutput(double value)
    {
        if (value < MinEnergyOutput ||
            value >= MaxEnergyOutput)
        {
            throw new ArgumentException(
                "Provider is not registered, because of it's EnergyOutput");
        }
    }
}

