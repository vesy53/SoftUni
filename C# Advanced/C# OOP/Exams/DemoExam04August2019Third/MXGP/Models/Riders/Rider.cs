namespace MXGP.Models.Riders
{
    using System;

    using Contracts;
    using MXGP.Models.Motorcycles.Contracts;
    using MXGP.Utilities.Messages;

    public class Rider : IRider
    {
        private const int DefoultLength = 5;

        private string name;

        public Rider(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) ||
                    value.Length < DefoultLength)
                {
                    throw new ArgumentException(
                        string.Format(
                            ExceptionMessages.InvalidName,
                            value, DefoultLength));
                }

                this.name = value;
            }
        }

        public IMotorcycle Motorcycle { get; private set; }

        public int NumberOfWins { get; private set; }

        //o	Rider can participate in race, ONLY if he has motorcycle (motorcycle is not null)

        public bool CanParticipate => this.Motorcycle != null;

        public void AddMotorcycle(IMotorcycle motorcycle)
        {
            // TODO
            this.Motorcycle = motorcycle ?? throw new ArgumentNullException(
                nameof(motorcycle),
                ExceptionMessages.MotorcycleInvalid);
        }

        public void WinRace()
        {
            this.NumberOfWins++;
        }
    }
}
