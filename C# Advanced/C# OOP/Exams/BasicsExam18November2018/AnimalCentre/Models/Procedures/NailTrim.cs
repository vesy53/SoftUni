namespace AnimalCentre.Models.Procedures
{
    using AnimalCentre.Models.Contracts;

    public class NailTrim : Procedure
    {
        private const int DecreaseHappiness = 7;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            animal.Happiness -= DecreaseHappiness;
        }
    }
}
