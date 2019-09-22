namespace MXGP.Models.Riders
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
                //o	If the name is null, empty or less than 5 symbols throw an ArgumentException with message
                //"Name {name} cannot be less than 5 symbols."

                if (string.IsNullOrEmpty(value) ||
                    value.Length < 5)
                {
                    throw new ArgumentException(
                        $"Name {value} cannot be less than 5 symbols.");
                }

                this.name = value;
            }
        }

        public IMotorcycle Motorcycle { get; private set; }

        public int NumberOfWins { get; private set; }

        //TODO
        //o	Rider can participate in race, ONLY if he has motorcycle (motorcycle is not null)
        public bool CanParticipate 
            => this.Motorcycle != null;

        public void AddMotorcycle(IMotorcycle motorcycle)
        {
            //This method adds a motorcycle to the rider. 
            //If the motorcycle null, throw ArgumentNullException with message "Motorcycle cannot be null.".
            //If motorcycle is not null, save it and after that rider can participate to race.

            if (motorcycle == null)
            {
                throw new ArgumentNullException(nameof(motorcycle), 
                    ExceptionMessages.MotorcycleInvalid);
            }
            else
            {
                this.Motorcycle = motorcycle;
            }
        }

        public void WinRace()
        {
            // When rider win race, number of wins should be increased.

            this.NumberOfWins++;
        }
    }
}
