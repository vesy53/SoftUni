namespace AnimalCentre.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using global::AnimalCentre.Common;
    using global::AnimalCentre.Core.Contracts;
    using global::AnimalCentre.Core.Factories;
    using global::AnimalCentre.Core.Factories.Contracts;
    using global::AnimalCentre.Models.Contracts;
    using global::AnimalCentre.Models.Hotels;
    using global::AnimalCentre.Models.Procedures;

    public class AnimalCentre : IAnimalCentre
    {
        private readonly IAnimalFactory animalFactory;
        private readonly IHotel hotel;
        private readonly List<IProcedure> procedures;
        private readonly Dictionary<string, List<string>> adoptedAnimals;

        public AnimalCentre()
        {
            this.animalFactory = new AnimalFactory();
            this.hotel = new Hotel();
            this.procedures = new List<IProcedure>();
            this.adoptedAnimals = new Dictionary<string, List<string>>();
        }

        public IReadOnlyDictionary<string, List<string>> AdoptedAnimals
            => this.adoptedAnimals;

        public string RegisterAnimal(
            string type, 
            string name,
            int energy,
            int happiness, 
            int procedureTime)
        {
            IAnimal animal = this.animalFactory
                .CreateAnimal(type, name, energy, happiness, procedureTime);

            this.hotel.Accommodate(animal);

            return string.Format(
                ConstantMessages.SuccessfullyRegisteredAnimal,
                animal.Name);
        }

        public string Chip(string name, int procedureTime)
        {
            AnimalDoesntExist(name);

            IAnimal animal = TakeAnimal(name);

            IProcedure chip = new Chip();
            chip.DoService(animal, procedureTime);

            AddTypeProcedure(chip);

            return string.Format(
                ConstantMessages.HadProcedure,
                animal.Name,
                "chip");
        }

        public string Vaccinate(string name, int procedureTime)
        {
            AnimalDoesntExist(name);

            IAnimal animal = TakeAnimal(name);

            IProcedure vaccinate = new Vaccinate();
            vaccinate.DoService(animal, procedureTime);

            AddTypeProcedure(vaccinate);

            return string.Format(
                ConstantMessages.HadProcedure,
                animal.Name,
                "vaccination");
        }

        public string Fitness(string name, int procedureTime)
        {
            AnimalDoesntExist(name);

            IAnimal animal = TakeAnimal(name);

            IProcedure fitness = new Fitness();
            fitness.DoService(animal, procedureTime);

            AddTypeProcedure(fitness);

            return string.Format(
                ConstantMessages.HadProcedure,
                animal.Name,
                "fitness");
        }

        public string Play(string name, int procedureTime)
        {
            AnimalDoesntExist(name);

            IAnimal animal = TakeAnimal(name);

            IProcedure play = new Play();
            play.DoService(animal, procedureTime);

            AddTypeProcedure(play);

            return string.Format(
                ConstantMessages.PlayingProcedure,
                animal.Name,
                procedureTime);
        }

        public string DentalCare(string name, int procedureTime)
        {
            AnimalDoesntExist(name);

            IAnimal animal = TakeAnimal(name);

            IProcedure dentalCare = new DentalCare();
            dentalCare.DoService(animal, procedureTime);

            AddTypeProcedure(dentalCare);

            return string.Format(
                ConstantMessages.HadProcedure,
                animal.Name,
                "dental care");
        }

        public string NailTrim(string name, int procedureTime)
        {
            AnimalDoesntExist(name);

            IAnimal animal = TakeAnimal(name);

            IProcedure nailTrim = new NailTrim();
            nailTrim.DoService(animal, procedureTime);

            AddTypeProcedure(nailTrim);

            return string.Format(
                ConstantMessages.HadProcedure,
                animal.Name,
                "nail trim");
        }

        public string Adopt(string animalName, string owner)
        {
            AnimalDoesntExist(animalName);

            IAnimal animal = TakeAnimal(animalName);

            string result = animal.IsChipped == true
                ? string.Format(
                    ConstantMessages.AdoptedChipedAnimal,
                    owner,
                    "with")
               : string.Format(
                    ConstantMessages.AdoptedChipedAnimal,
                    owner,
                    "without");

            if (!adoptedAnimals.ContainsKey(owner))
            {
                adoptedAnimals.Add(owner, new List<string>());
            }

            adoptedAnimals[owner].Add(animalName);

            this.hotel.Adopt(animalName, owner);

            return result;
        }

        public string History(string type)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"{type}");

            foreach (IProcedure procedureInfo in this.procedures
                .Where(p => p.GetType().Name == type))
            {
                builder.AppendLine(procedureInfo.History());
            }

            return builder.ToString().TrimEnd();
        }

        private void AnimalDoesntExist(string name)
        {
            if (!this.hotel.Animals.ContainsKey(name))
            {
                throw new ArgumentException(
                    string.Format(
                        ExceptionMessages.NotExistAnimalName,
                        name));
            }
        }

        private IAnimal TakeAnimal(string name)
        {
            return this.hotel
                       .Animals
                       .FirstOrDefault(a => a.Key == name)
                       .Value;
        }

        private void AddTypeProcedure(IProcedure procedure)
        {
            this.procedures.Add(procedure);
        }
    }
}
