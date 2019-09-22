using System;

public class Harvester : Indentity
{
    private const int MinValue = 0;
    private const int MaxEnergyRequirement = 20000;

    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement) 
        : base(id)
    {
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public double OreOutput
    {
        get
        {
            return this.oreOutput;
        }

        protected set
        {
            ValidateOreOutput(value);

            this.oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get
        {
            return this.energyRequirement;
        }

        protected set
        {
            ValidateEnergyRequirement(value);

            this.energyRequirement = value;
        }
    }

    private static void ValidateOreOutput(double value)
    {
        if (value < MinValue)
        {
            throw new ArgumentException(
                "Harvester is not registered, because of it's OreOutput");
        }
    }

    private static void ValidateEnergyRequirement(double value)
    {
        if (value < MinValue ||
            value >= MaxEnergyRequirement)
        {
            throw new ArgumentException(
                "Harvester is not registered, because of it's EnergyRequirement");
        }
    }
}

