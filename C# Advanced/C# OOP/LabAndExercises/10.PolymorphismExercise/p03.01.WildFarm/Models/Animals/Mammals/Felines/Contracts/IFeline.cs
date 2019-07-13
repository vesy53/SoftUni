namespace p03._01.WildFarm.Models.Animals.Mammals.Felines.Contracts
{
    using p03._01.WildFarm.Models.Animals.Contracts;

    public interface IFeline : IAnimal
    {
        string Breed { get; }
    }
}
