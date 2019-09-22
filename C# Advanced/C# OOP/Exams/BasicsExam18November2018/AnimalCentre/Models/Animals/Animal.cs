namespace AnimalCentre.Models.Animals
{
    using System;

    using AnimalCentre.Common;
    using AnimalCentre.Models.Contracts;

    public abstract class Animal : IAnimal
    {
        private const string DefaultOwner = "Centre";
        private const int InvalidMinValue = 0;
        private const int InvalidMaxValue = 100;

        private int happiness;
        private int energy;

        protected Animal(
            string name, 
            int energy,
            int happiness,
            int procedureTime)
        {
            this.Name = name;
            this.Energy = energy;
            this.Happiness = happiness;
            this.ProcedureTime = procedureTime;

            this.Owner = DefaultOwner;
        }

        public string Name { get; private set; }

        public int Happiness
        {
            get
            {
                return this.happiness;
            }

            set
            {
                if (value < InvalidMinValue || 
                    value > InvalidMaxValue)
                {
                    throw new ArgumentException(
                        ExceptionMessages.InvalidHappiness);
                }

                this.happiness = value;
            }
        }

        public int Energy
        {
            get
            {
                return this.energy;
            }

            set
            {
                if (value < InvalidMinValue ||
                    value > InvalidMaxValue)
                {
                    throw new ArgumentException(
                        ExceptionMessages.InvalidEnergy);
                }

                this.energy = value;
            }
        }

        public int ProcedureTime { get; set; }

        public string Owner { get; set; }

        public bool IsAdopt { get; set; }

        public bool IsChipped { get; set; }

        public bool IsVaccinated { get; set; }
    }
}
