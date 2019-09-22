namespace AnimalCentre.Models.Procedures
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using AnimalCentre.Common;
    using AnimalCentre.Models.Contracts;

    public abstract class Procedure : IProcedure
    {
        private readonly List<IAnimal> procedureHistory;

        public Procedure()
        {
            this.procedureHistory = new List<IAnimal>();
        }
    
        public IReadOnlyCollection<IAnimal> ProcedureHistory => 
            this.procedureHistory.AsReadOnly();

        public virtual void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.ProcedureTime < procedureTime)
            {
                throw new ArgumentException(
                    ExceptionMessages.InvalidProcedureTime);
            }

            animal.ProcedureTime -= procedureTime;

            this.procedureHistory.Add(animal);
        }

        public string History()
        {
            StringBuilder builder = new StringBuilder();

            foreach (IAnimal animalInfo in this.ProcedureHistory)
            {
                builder.AppendLine(animalInfo.ToString());
            }

            return builder.ToString().TrimEnd();
        }
    }
}
