﻿namespace MXGP.Models.Races
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using MXGP.Models.Races.Contracts;
    using MXGP.Models.Riders.Contracts;
    using MXGP.Utilities.Messages;

    public class Race : IRace
    {
        private string name;
        private int laps;
        private readonly List<IRider> riders;

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
                //If the name is null, empty or less than 5 symbols throw an ArgumentException with message 
                //"Name {name} cannot be less than 5 symbols."

                if (string.IsNullOrEmpty(value) ||
                    string.IsNullOrWhiteSpace(value) ||
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

        public int Laps
        {
            get
            {
                return this.laps;
            }

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException(
                        string.Format(
                            ExceptionMessages.InvalidNumberOfLaps,
                            1));
                }

                this.laps = value;
            }
        }

        public IReadOnlyCollection<IRider> Riders 
            => this.riders.AsReadOnly();

        public void AddRider(IRider rider)
        {
            //This method adds a rider to the race if the rider is valid.
            //If a rider is not valid, throw an exception with the appropriate message.
            //Exceptions are:
            //•	If a rider is null throw an ArgumentNullException with message "Rider cannot be null."

            if (rider == null)
            {
                //throw new ArgumentNullException(nameof(rider),
                //    "Rider cannot be null.");

                throw new ArgumentNullException(
                        ExceptionMessages.RiderInvalid);
            }

            //•	If a rider cannot participate in the race (the rider doesn't own a motorcycle) 
            //throw an ArgumentException with message "Rider {rider name} could not participate in race."

            if (!rider.CanParticipate)
            {
                throw new ArgumentException(
                    string.Format(
                        ExceptionMessages.RiderNotParticipate,
                        rider.Name));
            }

            //•	If the rider already exists in the race throw an ArgumentNullException with message:
            //"Rider {rider name} is already added in {race name} race."

            if (this.riders.Any(r => r.Name == rider.Name))
            {
                //throw new ArgumentNullException(nameof(rider),
                //    $"Rider {rider.Name} is already added in {this.Name} race.");

                throw new ArgumentNullException(
                    string.Format(
                        ExceptionMessages.RiderAlreadyAdded,
                        rider.Name,
                        this.Name));
            }

            this.riders.Add(rider);
        }
    }
}
