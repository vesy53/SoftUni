namespace AnimalCentre.Core.Factories.Contracts
{
    using global::AnimalCentre.Models.Contracts;

    public interface IAnimalFactory
    {
        IAnimal CreateAnimal(
            string type,
            string name,
            int energy,
            int happiness,
            int procedureTime);
    }
}
