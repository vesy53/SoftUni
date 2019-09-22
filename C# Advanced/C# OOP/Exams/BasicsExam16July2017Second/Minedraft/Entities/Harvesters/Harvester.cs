using System;
using System.Text;

public abstract class Harvester : Identifier
{
    private const int MinValue = 0;
    private const int MaxValue = 20000;

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

    //public override string ToString()
    //{
    //    StringBuilder builder = new StringBuilder();
    //    // var typeName = GetType().Name.Equals("SonicHarvester") ? "Sonic" : "Hammer"; //third method

    //    builder.AppendLine($"{this.Type} Harvester - {this.Id}")
    //        .AppendLine($"Ore Output: {this.OreOutput}")
    //        .AppendLine($"Energy Requirement: {this.EnergyRequirement}");
    //
    //    string message = builder.ToString().TrimEnd();
    //    return message;
    //}

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
            value > MaxValue)
        {
            throw new ArgumentException(
                "Harvester is not registered, because of it's EnergyRequirement");
        }
    }
}
