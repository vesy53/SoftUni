using MXGP.Core.Contracts;
using MXGP.Models.Motorcycles;
using MXGP.Models.Motorcycles.Contracts;
using MXGP.Models.Races;
using MXGP.Models.Races.Contracts;
using MXGP.Models.Riders;
using MXGP.Models.Riders.Contracts;
using MXGP.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MXGP.Core
{
    public class ChampionshipController : IChampionshipController
    {
        private MotorcycleRepository motorcycleRepository;
        private RaceRepository raceRepository;
        private RiderRepository riderRepository;

        public ChampionshipController()
        {
            this.motorcycleRepository = new MotorcycleRepository();
            this.raceRepository = new RaceRepository();
            this.riderRepository = new RiderRepository();
        }

        public string AddMotorcycleToRider(string riderName, string motorcycleModel)
        {
            IMotorcycle motorcycle = this.motorcycleRepository
                .GetByName(motorcycleModel);
            IRider rider = this.riderRepository
                .GetByName(riderName);

            if (rider is null)
            {
                throw new InvalidOperationException(
                    $"Rider {riderName} could not be found.");
            }

            if (motorcycle is null)
            {
                throw new InvalidOperationException(
                    $"Motorcycle {motorcycleModel} could not be found.");
            }

            rider.AddMotorcycle(motorcycle);

            return $"Rider {riderName} received motorcycle {motorcycleModel}.";
        }

        public string AddRiderToRace(string raceName, string riderName)
        {
            IRace race = this.raceRepository
                .GetByName(raceName);

            if (race is null)
            {
                throw new InvalidOperationException(
                    $"Race {raceName} could not be found.");
            }

            IRider rider = this.riderRepository
                .GetByName(riderName);

            if (rider is null)
            {
                throw new InvalidOperationException(
                    $"Rider {riderName} could not be found.");
            }

            race.AddRider(rider);

            return $"Rider {riderName} added in {raceName} race.";
        }

        public string CreateMotorcycle(string type, string model, int horsePower)
        {
            //Create a motorcycle with the provided model and horsepower and add it to the repository. 
            //There are two types of motorcycles: "SpeedMotorcycle" and "PowerMotorcycle".
            //If the motorcycle already exists in the appropriate repository throw an ArgumentException with following message:
            //"Motorcycle {model} is already created."
            //If the motorcycle is successfully created, the method should return the following message:
            //"{"SpeedMotorcycle"/ "PowerMotorcycle"} {model} is created."
            IMotorcycle motorcycle = this.motorcycleRepository
                .GetByName(model);

            if (motorcycle != null)
            {
                throw new ArgumentException(
                    $"Motorcycle {model} is already created.");
            }

            if (type == "Speed")
            {
                motorcycle = new SpeedMotorcycle(model, horsePower);
            }
            else if (type == "Power")
            {
                motorcycle = new PowerMotorcycle(model, horsePower);
            }

            this.motorcycleRepository.Add(motorcycle);

            return $"{motorcycle.GetType().Name} {model} is created.";
        }

        public string CreateRace(string name, int laps)
        {
            IRace race = this.raceRepository
                .GetByName(name);

            if (race != null)
            {
                throw new InvalidOperationException(
                    $"Race {name} is already created.");
            }

            race = new Race(name, laps);

            this.raceRepository.Add(race);

            return $"Race {name} is created.";
        }

        public string CreateRider(string riderName)
        {
            //Creates a rider with the given name and adds it to the appropriate repository.
            //The method should return the following message:
            //"Rider {name} is created."
            //If a rider with the given name already exists in the rider repository, throw an ArgumentException with message
            //"Rider {name} is already created."
            IRider rider = this.riderRepository
                .GetByName(riderName);

            if (rider != null)
            {
                throw new ArgumentException(
                    $"Rider {riderName} is already created.");
            }

            rider = new Rider(riderName);

            this.riderRepository.Add(rider);

            return $"Rider {riderName} is created.";
        }

        public string StartRace(string raceName)
        {
            IRace race = this.raceRepository
                .GetByName(raceName);

            if (race is null)
            {
                throw new InvalidOperationException(
                    $"Race {raceName} could not be found.");
            }

            if (race.Riders.Count < 3)
            {
                throw new InvalidOperationException(
                    $"Race {raceName} cannot start with less than 3 participants.");
            }

            var sortedRiders = race
                .Riders
                .OrderByDescending(r => r.Motorcycle.CalculateRacePoints(race.Laps))
                .Take(3)
                .ToList();

            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"Rider {sortedRiders[0].Name} wins {raceName} race.");
            builder.AppendLine($"Rider {sortedRiders[1].Name} is second in {raceName} race.");
            builder.AppendLine($"Rider {sortedRiders[2].Name} is third in {raceName} race.");

            this.raceRepository.Remove(race);

            return builder.ToString().TrimEnd();
        }
    }
}
