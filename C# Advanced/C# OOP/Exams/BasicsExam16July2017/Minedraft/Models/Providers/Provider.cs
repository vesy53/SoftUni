using System;

public class Provider : Indentity
{
    private const int MinEnergyOutpu = 0;
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
        //TODO
        if (value < MinEnergyOutpu ||
            value > MaxEnergyOutput)
        {
            throw new ArgumentException(
                "Provider is not registered, because of it's EnergyOutput");
        }
    }
}

