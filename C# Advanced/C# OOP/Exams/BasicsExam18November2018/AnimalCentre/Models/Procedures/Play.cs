namespace AnimalCentre.Models.Procedures
{
    using AnimalCentre.Models.Contracts;

    public class Play : Procedure
    {
        private const int IncreaseHappiness = 12;
        private const int DecreaseEnergy = 6;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            animal.Happiness += IncreaseHappiness;
            animal.Energy -= DecreaseEnergy;
        }
    }
}
