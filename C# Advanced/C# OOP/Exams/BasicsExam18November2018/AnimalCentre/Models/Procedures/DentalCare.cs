namespace AnimalCentre.Models.Procedures
{    
    using AnimalCentre.Models.Contracts;

    public class DentalCare : Procedure
    {
        private const int IncreaseHappiness = 12;
        private const int IncreaseEnergy = 10;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            animal.Happiness += IncreaseHappiness;
            animal.Energy += IncreaseEnergy;
        }
    }
}
