namespace p03._01.WildFarm.Models.Animals.Birds.Contracts
{
    using p03._01.WildFarm.Models.Animals.Contracts;

    public interface IBird : IAnimal
    {
        double WingSize { get; }
    }
}
