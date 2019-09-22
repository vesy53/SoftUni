namespace AnimalCentre.Models.Hotels
{
    using System;
    using System.Collections.Generic;
    
    using AnimalCentre.Common;
    using AnimalCentre.Models.Contracts;

    public class Hotel : IHotel
    {
        private const int DefaultCapasity = 10;

        private readonly int capacity;
        private readonly Dictionary<string, IAnimal> animals;

        public Hotel()
        {
            this.capacity = DefaultCapasity;

            this.animals = new Dictionary<string, IAnimal>();
        }

        public int Capacity => this.capacity;

        public IReadOnlyDictionary<string, IAnimal> Animals => this.animals;

        public void Accommodate(IAnimal animal)
        {
            if (this.animals.Count >= this.Capacity)
            {
                throw new InvalidOperationException(
                    ExceptionMessages.InvalidCapasity);
            }

            if (this.animals.ContainsKey(animal.Name))
            {
                throw new ArgumentException(
                    string.Format(
                        ExceptionMessages.ExistAnimal,
                        animal.Name));
            }

            this.animals.Add(animal.Name, animal);
        }

        public void Adopt(string animalName, string owner)
        {
            if (!this.animals.ContainsKey(animalName))
            {
                throw new ArgumentException(
                    string.Format(
                        ExceptionMessages.NotExistAnimalName,
                        animalName));
            }

            this.animals[animalName].Owner = owner;
            this.animals[animalName].IsAdopt = true;

            this.animals.Remove(animalName);
        }
    }
}
