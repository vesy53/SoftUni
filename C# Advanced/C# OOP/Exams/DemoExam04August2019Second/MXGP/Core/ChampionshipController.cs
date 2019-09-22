namespace MXGP.Core
{
    using System;
    using System.Linq;
    using System.Text;

    using Contracts;
    using Factories.Contracts;
    using MXGP.Core.Factories;
    using MXGP.Models.Motorcycles.Contracts;
    using MXGP.Models.Races.Contracts;
    using MXGP.Models.Riders.Contracts;
    using MXGP.Repositories;
    using MXGP.Utilities.Messages;

    public class ChampionshipController : IChampionshipController
    {
        private readonly IRaceFactory raceFactory;
        private readonly IRiderFactory riderFactory;
        private readonly IMotorcycleFactory motorcycleFactory;

        private readonly MotorcycleRepository motorcycleRepository;
        private readonly RaceRepository raceRepository;
        private readonly RiderRepository riderRepository;

        public ChampionshipController()
        {
            this.raceFactory = new RaceFactory();
            this.riderFactory = new RiderFactory();
            this.motorcycleFactory = new MotorcycleFactory();

            this.motorcycleRepository = new MotorcycleRepository();
            this.raceRepository = new RaceRepository();
            this.riderRepository = new RiderRepository();
        }

        public string AddMotorcycleToRider(string riderName, string motorcycleModel)
        {
            //Gives the motorcycle with given name to the rider with given name (if exists).

            IRider rider = this.riderRepository
                .GetByName(riderName);

            //If the rider does not exist in rider repository, throw InvalidOperationException with message 
            //•	"Rider {name} could not be found."

            if (rider == null)
            {
                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.RiderNotFound,
                        riderName));
            }

            //If the motorcycle does not exist in motorcycle repository, throw InvalidOperationException with message 
            //•	"Motorcycle {name} could not be found."
            IMotorcycle motorcycle = this.motorcycleRepository
                .GetByName(motorcycleModel);

            if (motorcycle == null)
            {
                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.MotorcycleNotFound,
                        motorcycleModel));
            }

            //If everything is successful you should add the motorcycle to the rider and return the following message:

            rider.AddMotorcycle(motorcycle);

            string result = string.Format(
                OutputMessages.MotorcycleAdded,
                riderName,
                motorcycleModel);

            return result;
        }

        public string AddRiderToRace(string raceName, string riderName)
        {
            //Adds a rider to the race.

            IRace race = this.raceRepository
                .GetByName(raceName);

            //If the race does not exist in the race repository, throw an InvalidOperationException with message:
            //•	"Race {name} could not be found."

            if (race == null)
            {
                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.RaceNotFound,
                        raceName));
            }

            //If the rider does not exist in the rider repository, throw an InvalidOperationException with message:
            //•	"Rider {name} could not be found."

            IRider rider = this.riderRepository
                .GetByName(riderName);

            if (rider == null)
            {
                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.RiderNotFound,
                        riderName));
            }

            //If everything is successful, you should add the rider to the race and return the following message:

            race.AddRider(rider);

            string result = string.Format(
                 OutputMessages.RiderAdded,
                 riderName,
                 raceName);

            return result;
        }

        public string CreateMotorcycle(string type, string model, int horsePower)
        {
            //Create a motorcycle with the provided model and horsepower and add it to the repository. 
            //There are two types of motorcycles: "SpeedMotorcycle" and "PowerMotorcycle".

            IMotorcycle getMotorcycle = this.motorcycleRepository
                .GetByName(model);

            //If the motorcycle already exists in the appropriate repository throw an ArgumentException with following message:
            //"Motorcycle {model} is already created."

            if (getMotorcycle != null)
            {
                throw new ArgumentException(
                    string.Format(
                        ExceptionMessages.MotorcycleExists,
                        model));
            }

            IMotorcycle motorcycle = this.motorcycleFactory
                .CreateMotorcycle(type, model, horsePower);

            this.motorcycleRepository.Add(motorcycle);

            //If the motorcycle is successfully created, the method should return the following message:

            string result = string.Format(
                 OutputMessages.MotorcycleCreated,
                 motorcycle.GetType().Name,
                 model);

            return result;
        }

        public string CreateRace(string name, int laps)
        {
            //Creates a race with the given name and laps and adds it to the race repository.

            IRace race = this.raceRepository
                .GetByName(name);

            //If the race with the given name already exists, throw an InvalidOperationException with message:
            //•	"Race {name} is already created."

            if (race != null)
            {
                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.RaceExists,
                        name));
            }

            //If everything is successful you should return the following message:

            race = this.raceFactory
                .CreateRace(name, laps);

            this.raceRepository.Add(race);

            string result = string.Format(
                  OutputMessages.RaceCreated,
                  name);

            return result;
        }

        public string CreateRider(string riderName)
        {
            //Creates a rider with the given name and adds it to the appropriate repository.

            IRider rider = this.riderRepository
                .GetByName(riderName);

            if (rider != null)
            {
                //If a rider with the given name already exists in the rider repository, throw an ArgumentException with message 
                //"Rider {name} is already created."

                throw new ArgumentException(
                    string.Format(
                        ExceptionMessages.RiderExists,
                        riderName));
            }

            rider = this.riderFactory
                .CreateRider(riderName);

            this.riderRepository.Add(rider);

            //The method should return the following message:
            //"Rider {name} is created."

            string result = string.Format(
                  OutputMessages.RiderCreated,
                  riderName);

            return result;
        }

        public string StartRace(string raceName)
        {
            //If everything is valid, you should arrange all riders and then return the three fastest riders. 
            //To do this you should sort all riders in descending order by the result of CalculateRacePoints 
            //method in the motorcycle object. At the end, if everything is valid remove this race from race repository.

            IRace race = this.raceRepository
                .GetByName(raceName);

            //If the race does not exist in race repository, throw an InvalidOperationException with message:
            //•	"Race {name} could not be found."

            if (race == null)
            {
                throw new InvalidOperationException(
                   string.Format(
                       ExceptionMessages.RaceNotFound,
                       raceName));
            }

            //If the participants in the race are less than 3, throw an InvalidOperationException with message:
            //•	"Race {race name} cannot start with less than 3 participants."

            if (race.Riders.Count < 3)
            {
                throw new InvalidOperationException(
                    string.Format(
                       ExceptionMessages.RaceInvalid,
                       raceName, 3));
            }

            //If everything is successful, you should return the following message:
            //•	"Rider {first rider name} wins {race name} race."
            //"Rider {second rider name} is second in {race name} race."
            //"Rider {third rider name} is third in {race name} race."

            var sortRiders = race.Riders
                .OrderByDescending(r => r.Motorcycle.CalculateRacePoints(race.Laps))
                .Take(3)
                .ToList();

            StringBuilder builder = new StringBuilder();

            builder.AppendLine(
                string.Format(
                    OutputMessages.RiderFirstPosition,
                    sortRiders[0].Name, raceName));
            builder.AppendLine(
                string.Format(
                    OutputMessages.RiderSecondPosition,
                    sortRiders[1].Name, raceName));
            builder.AppendLine(
                string.Format(
                    OutputMessages.RiderThirdPosition,
                    sortRiders[2].Name, raceName));

            this.raceRepository.Remove(race);

            return builder.ToString().TrimEnd();
        }
    }
}
