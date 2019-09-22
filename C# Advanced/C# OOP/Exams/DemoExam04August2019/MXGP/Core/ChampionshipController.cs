namespace MXGP.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Contracts;
    using MXGP.Factories;
    using MXGP.Models.Motorcycles;
    using MXGP.Models.Motorcycles.Contracts;
    using MXGP.Models.Races;
    using MXGP.Models.Races.Contracts;
    using MXGP.Models.Riders;
    using MXGP.Models.Riders.Contracts;
    using MXGP.Repositories;
    using MXGP.Repositories.Contracts;
    using MXGP.Utilities.Messages;

    public class ChampionshipController : IChampionshipController
    {
        private readonly MotorcycleFactory motorcycleFactory;

        private readonly IRepository<IMotorcycle> motoRepository;
        private readonly IRepository<IRider> riderRepository;
        private readonly IRepository<IRace> raceRepository;

        public ChampionshipController()
        {
            this.motorcycleFactory = new MotorcycleFactory();

            this.motoRepository = new MotorcycleRepository();
            this.riderRepository = new RiderRepository();
            this.raceRepository = new RaceRepository();
        }

        public string CreateRider(string riderName)
        {
            IRider rider = new Rider(riderName);

            IRider getRider = this.riderRepository
                .GetByName(riderName);

            if (getRider == null)
            {
                this.riderRepository.Add(rider);
            }
            else
            {
                throw new ArgumentException(
                    string.Format(
                        ExceptionMessages.RiderExists,
                        riderName));
                //throw new ArgumentException(
                    //$"Rider {riderName} is already created.");

            }

            return string.Format(OutputMessages.RiderCreated, riderName);
        }

        public string CreateMotorcycle(string type, string model, int horsePower)
        {
            IMotorcycle motorcycle = this.motorcycleFactory
                .CreateMotorcycle(type, model, horsePower);

            IMotorcycle getMotorcycle = this.motoRepository
                .GetByName(model);

            if (getMotorcycle == null)
            {
                this.motoRepository.Add(motorcycle);
            }
            else
            {
                throw new ArgumentException(
                    string.Format(
                        ExceptionMessages.MotorcycleExists,
                        model));
            }

            //if (type == "Speed")
            //{
            //    motorcycle = new SpeedMotorcycle(model, horsePower);
            //}
            //else if (type == "Power")
            //{
            //    motorcycle = new PowerMotorcycle(model, horsePower);
            //}

            return string.Format(
                OutputMessages.MotorcycleCreated, 
                motorcycle.GetType().Name,
                model);
        }

        public string AddMotorcycleToRider(string riderName, string motorcycleModel)
        {
            IRider rider = this.riderRepository
                .GetByName(riderName);

            if (rider == null)
            {
                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.RiderNotFound,
                        riderName));
            }

            IMotorcycle motorcycle = this.motoRepository
                .GetByName(motorcycleModel);

            if (motorcycle == null)
            {
                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.MotorcycleNotFound,
                        motorcycleModel));
            }

            rider.AddMotorcycle(motorcycle);

            return string.Format(
                OutputMessages.MotorcycleAdded,
                riderName,
                motorcycleModel);
        }

        public string AddRiderToRace(string raceName, string riderName)
        {
            IRace race = this.raceRepository
                .GetByName(raceName);

            if (race == null)
            {
                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.RaceNotFound,
                        raceName));
            }

            IRider rider = this.riderRepository
                .GetByName(riderName);

            if (rider == null)
            {
                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.RiderNotFound,
                        riderName));
            }

            race.AddRider(rider);

            return string.Format(
                OutputMessages.RiderAdded,
                riderName,
                raceName);
        }

        public string CreateRace(string name, int laps)
        {
            IRace race = new Race(name, laps);

            IRace getRace = this.raceRepository
                .GetByName(name);

            if (getRace == null)
            {
                this.raceRepository.Add(race);
            }
            else
            {
                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.RaceExists,
                        name));
            }

            this.raceRepository.Add(race); 

            return string.Format(
                OutputMessages.RaceCreated, 
                name);
        }

        public string StartRace(string raceName)
        {
            IRace race = this.raceRepository
                .GetByName(raceName);

            if (race == null)
            {
                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.RaceNotFound,
                        raceName));
            }

            if (race.Riders.Count < 3)
            {
                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.RaceInvalid,
                        raceName,
                        3));
            }

            var riders = race.Riders
                .OrderByDescending(r => r.Motorcycle.CalculateRacePoints(race.Laps))
                .Take(3)
                .ToList();
            
            StringBuilder builder = new StringBuilder();
            
            builder.AppendLine($"Rider {riders[0].Name} wins {raceName} race.")
                   .AppendLine($"Rider {riders[1].Name} is second in {raceName} race.")
                   .AppendLine($"Rider {riders[2].Name} is third in {raceName} race.");
            
            this.raceRepository.Remove(race);
            
            return builder.ToString().TrimEnd();
        }
    }
}
