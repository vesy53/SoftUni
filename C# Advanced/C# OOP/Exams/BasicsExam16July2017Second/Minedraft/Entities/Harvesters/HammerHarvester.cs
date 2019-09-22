public class HammerHarvester : Harvester
{
    private const int OreOutputIncrease = 3;
    private const int EnergyRequirementIncrease = 2;

    public HammerHarvester(string id, double oreOutput, double energyRequirement)
        : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput *= OreOutputIncrease;
        this.EnergyRequirement *= EnergyRequirementIncrease;
    }

   //public override string Type => "Hammer";
}
