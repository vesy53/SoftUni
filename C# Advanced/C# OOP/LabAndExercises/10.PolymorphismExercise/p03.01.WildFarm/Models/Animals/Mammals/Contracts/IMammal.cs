namespace p03._01.WildFarm.Models.Animals.Mammals.Contracts
{
    using p03._01.WildFarm.Models.Animals.Contracts;

    public interface IMammal : IAnimal
    {
        string LivingRegion { get; }
    }
}
