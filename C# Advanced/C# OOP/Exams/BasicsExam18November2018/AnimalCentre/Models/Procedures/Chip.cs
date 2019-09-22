namespace AnimalCentre.Models.Procedures
{
    using System;
    
    using AnimalCentre.Common;
    using AnimalCentre.Models.Contracts;

    public class Chip : Procedure
    {
        private const int DecreaseHappiness = 5;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            if (animal.IsChipped == true)
            {
                throw new ArgumentException(
                    string.Format(
                        ExceptionMessages.AnimalChipped,
                        animal.Name));
            }

            animal.IsChipped = true;
            animal.Happiness -= DecreaseHappiness;
        }
    }
}