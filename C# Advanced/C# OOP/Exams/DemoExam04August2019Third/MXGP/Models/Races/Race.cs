namespace MXGP.Models.Races
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using MXGP.Models.Riders.Contracts;
    using MXGP.Utilities.Messages;

    public class Race : IRace
    {
        private const int DefoultLength = 5;
        private const int DefaultLap = 1;

        private string name;
        private int laps;
        private List<IRider> riders;

        public Race(string name, int laps)
        {
            this.Name = name;
            this.Laps = laps;

            this.riders = new List<IRider>();
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

        public int Laps
        {
            get
            {
                return this.laps;
            }

            private set
            {
                if (value < DefaultLap)
                {
                    throw new ArgumentException(
                        string.Format(
                            ExceptionMessages.InvalidNumberOfLaps,
                            DefaultLap));
                }

                this.laps = value;
            }
        }

        public IReadOnlyCollection<IRider> Riders 
            => this.riders.AsReadOnly();

        public void AddRider(IRider rider)
        {
            if (rider == null)
            {
                throw new ArgumentNullException(
                    ExceptionMessages.RiderInvalid);
            }

            if (!rider.CanParticipate)
            {
                throw new ArgumentException(
                    string.Format(
                        ExceptionMessages.RiderNotParticipate,
                        rider.Name));
            }

            if (this.riders.Any(r => r.Name == rider.Name))
            {
                throw new ArgumentNullException(
                    string.Format(
                        ExceptionMessages.RiderAlreadyAdded,
                        rider.Name, this.Name));
            }

            this.riders.Add(rider);
        }
    }
}
