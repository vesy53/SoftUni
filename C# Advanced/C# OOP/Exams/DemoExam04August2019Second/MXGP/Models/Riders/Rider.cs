﻿namespace MXGP.Models.Riders
{
    using System;

    using MXGP.Models.Motorcycles.Contracts;
    using MXGP.Models.Riders.Contracts;
    using MXGP.Utilities.Messages;

    public class Rider : IRider
    {
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
                if (string.IsNullOrWhiteSpace(value) ||
                    value.Length < 5)
                {
                    throw new ArgumentException(
                        string.Format(
                            ExceptionMessages.InvalidName,
                            value, 5));
                }

                this.name = value;
            }
        }

        public IMotorcycle Motorcycle { get; private set; }

        public int NumberOfWins { get; private set; }

        public bool CanParticipate => this.Motorcycle != null;

        public void AddMotorcycle(IMotorcycle motorcycle)
        {
            //This method adds a motorcycle to the rider. If the motorcycle null,
            //throw ArgumentNullException with message "Motorcycle cannot be null.".

            if (motorcycle is null)
            {
                //throw new ArgumentNullException(nameof(motorcycle),
                //    "Motorcycle cannot be null.");

                throw new ArgumentNullException(
                    ExceptionMessages.MotorcycleInvalid);
            }

            //If motorcycle is not null, save it and after that rider can participate to race.

            this.Motorcycle = motorcycle;
        }

        public void WinRace()
        {
            // When rider win race, number of wins should be increased.
            this.NumberOfWins++;
        }
    }
}
