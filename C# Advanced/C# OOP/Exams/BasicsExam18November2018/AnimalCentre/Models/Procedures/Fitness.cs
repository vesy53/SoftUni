namespace AnimalCentre.Models.Procedures
{
    using AnimalCentre.Models.Contracts;

    public class Fitness : Procedure
    {
        private const int DecreaseHappiness = 3;
        private const int IncreaseEnergy = 10;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            animal.Happiness -= DecreaseHappiness;
            animal.Energy += IncreaseEnergy;
        }
    }
}
