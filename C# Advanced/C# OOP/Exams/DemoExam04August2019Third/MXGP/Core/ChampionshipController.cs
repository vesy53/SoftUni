namespace MXGP.Core
{
    using System;
    using System.Linq;
    using System.Text;

    using Contracts;
    using Factories.Contracts;
    using MXGP.Models.Motorcycles.Contracts;
    using MXGP.Models.Races.Contracts;
    using MXGP.Models.Riders.Contracts;
    using MXGP.Repositories;
    using MXGP.Utilities.Messages;

    public class ChampionshipController : IChampionshipController
    {
        private readonly IMotorcycleFactory motorcycleFactory;
        private readonly IRaceFactory raceFactory;
        private readonly IRiderFactory riderFactory;

        private readonly MotorcycleRepository motorcycleRepository;
        private readonly RaceRepository raceRepository;
        private readonly RiderRepository riderRepository;

        public ChampionshipController(
            IMotorcycleFactory motorcycleFactory, 
            IRaceFactory raceFactory, 
            IRiderFactory riderFactory, 
            MotorcycleRepository motorcycleRepository, 
            RaceRepository raceRepository,
            RiderRepository riderRepository)
        {
            this.motorcycleFactory = motorcycleFactory;
            this.raceFactory = raceFactory;
            this.riderFactory = riderFactory;
            this.motorcycleRepository = motorcycleRepository;
            this.raceRepository = raceRepository;
            this.riderRepository = riderRepository;
        }

        public string AddMotorcycleToRider(string riderName, string motorcycleModel)
        {
            bool isExistRider = this.riderRepository
                .GetAll()
                .Any(r => r.Name == riderName);

            if (!isExistRider)
            {
                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.RiderNotFound,
                        riderName));
            }

            bool isExistMotorcycle = this.motorcycleRepository
                .GetAll()
                .Any(m => m.Model == motorcycleModel);

            if (!isExistMotorcycle)
            {
                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.MotorcycleNotFound,
                        motorcycleModel));
            }

            IMotorcycle motorcycle = this.motorcycleRepository
                .GetByName(motorcycleModel);

            IRider rider = this.riderRepository
                .GetByName(riderName);

            rider.AddMotorcycle(motorcycle);

            string result = string.Format(
                OutputMessages.MotorcycleAdded,
                riderName,
                motorcycleModel);

            return result;
        }

        public string AddRiderToRace(string raceName, string riderName)
        {
            bool isExistRace = this.raceRepository
                .GetAll()
                .Any(r => r.Name == raceName);

            if (!isExistRace)
            {
                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.RaceNotFound,
                        raceName));
            }

            bool isExistRider = this.riderRepository
               .GetAll()
               .Any(r => r.Name == riderName);

            if (!isExistRider)
            {
                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.RiderNotFound,
                        riderName));
            }

            IRider rider = this.riderRepository
                .GetByName(riderName);

            IRace race = this.raceRepository
                .GetByName(raceName);

            race.AddRider(rider);

            string result = string.Format(
                OutputMessages.RiderAdded,
                riderName,
                raceName);

            return result;
        }

        public string CreateMotorcycle(string type, string model, int horsePower)
        {
            bool isExist = this.motorcycleRepository
                .GetAll()
                .Any(m => m.Model == model);

            if (isExist)
            {
                throw new ArgumentException(
                    string.Format(
                        ExceptionMessages.MotorcycleExists,
                        model));
            }

            IMotorcycle motorcycle = this.motorcycleFactory
                .CreateMotorcycle(type, model, horsePower);

            this.motorcycleRepository.Add(motorcycle);

            string result = string.Format(
                OutputMessages.MotorcycleCreated,
               motorcycle.GetType().Name,
               model);

            return result;
        }

        public string CreateRace(string name, int laps)
        {
            bool isExistRace = this.raceRepository
               .GetAll()
               .Any(r => r.Name == name);

            if (isExistRace)
            {
                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.RaceExists,
                        name));
            }

            IRace race = this.raceFactory
                .CreateRace(name, laps);

            this.raceRepository.Add(race);

            string result = string.Format(
                OutputMessages.RaceCreated,
                name);

            return result;
        }

        public string CreateRider(string riderName)
        {
            bool isExist = this.riderRepository
                .GetAll()
                .Any(r => r.Name == riderName);

            if (isExist)
            {
                throw new ArgumentException(
                    string.Format(
                        ExceptionMessages.RiderExists,
                        riderName));
            }

            IRider rider = this.riderFactory
                .CreateRider(riderName);

            this.riderRepository.Add(rider);

            string result = string.Format(
                OutputMessages.RiderCreated, 
                riderName);

            return result;
        }

        public string StartRace(string raceName)
        {
            bool isExist = this.raceRepository
                .GetAll()
                .Any(r => r.Name == raceName);

            if (!isExist)
            {
                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.RaceNotFound,
                        raceName));
            }

            IRace race = this.raceRepository
                .GetByName(raceName);

            if (race.Riders.Count < 3)
            {
                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.RaceInvalid,
                        raceName, 3));
            }

            var sortRiders = race
                .Riders
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

            //At the end, if everything is valid remove this race from race repository.
            this.raceRepository.Remove(race);

            return builder.ToString().TrimEnd();
        }
    }
}
