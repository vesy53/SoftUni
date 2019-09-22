public class HammerHarvester : Harvester
{
    private const int OreOutputIncrease = 2;

    public HammerHarvester(string id, double oreOutput, double energyRequirement)
        : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput += oreOutput * OreOutputIncrease;
        this.EnergyRequirement = energyRequirement + energyRequirement;
    }
}
