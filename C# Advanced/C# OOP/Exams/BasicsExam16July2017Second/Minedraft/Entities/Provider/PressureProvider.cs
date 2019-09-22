public class PressureProvider : Provider
{
    private const double EnergyOutputIncrease = 0.5;

    public PressureProvider(string id, double energyOutput) 
        : base(id, energyOutput)
    {
        this.EnergyOutput += energyOutput * EnergyOutputIncrease;
    }
}