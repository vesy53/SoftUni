namespace AnimalCentre.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    using global::AnimalCentre.Common;
    using global::AnimalCentre.Core.Contracts;
    using global::AnimalCentre.IO;
    using global::AnimalCentre.IO.Contracts;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly IAnimalCentre animalCentre;

        public Engine()
        {
            this.reader = new Reader();
            this.writer = new Writer();

            this.animalCentre = new AnimalCentre();
        }

        public void Run()
        {
            string input = this.reader.ReadLine();

            while (input.Equals("End") == false)
            {
                try
                {
                    string[] tokens = input
                        .Split(" ",
                            StringSplitOptions
                            .RemoveEmptyEntries);

                    string command = tokens[0];

                    string name = string.Empty;
                    string result = string.Empty;
                    int procedureTime = 0;

                    switch (command)
                    {
                        case "RegisterAnimal":
                            string type = tokens[1];
                            name = tokens[2];
                            int energy = int.Parse(tokens[3]);
                            int happiness = int.Parse(tokens[4]);
                            procedureTime = int.Parse(tokens[5]);

                            result = this.animalCentre
                                .RegisterAnimal(type, name, energy, happiness, procedureTime);
                            break;
                        case "Chip":
                            name = tokens[1];
                            procedureTime = int.Parse(tokens[2]);

                            result = this.animalCentre
                                .Chip(name, procedureTime);
                            break;
                        case "Vaccinate":
                            name = tokens[1];
                            procedureTime = int.Parse(tokens[2]);

                            result = this.animalCentre
                                .Vaccinate(name, procedureTime);
                            break;
                        case "Fitness":
                            name = tokens[1];
                            procedureTime = int.Parse(tokens[2]);

                            result = this.animalCentre
                                .Fitness(name, procedureTime);
                            break;
                        case "Play":
                            name = tokens[1];
                            procedureTime = int.Parse(tokens[2]);

                            result = this.animalCentre
                                .Play(name, procedureTime);
                            break;
                        case "DentalCare":
                            name = tokens[1];
                            procedureTime = int.Parse(tokens[2]);

                            result = this.animalCentre
                                .DentalCare(name, procedureTime);
                            break;
                        case "NailTrim":
                            name = tokens[1];
                            procedureTime = int.Parse(tokens[2]);

                            result = this.animalCentre
                                .NailTrim(name, procedureTime);
                            break;
                        case "Adopt":
                            name = tokens[1];
                            string owner = tokens[2];

                            result = this.animalCentre
                                .Adopt(name, owner);
                            break;
                        case "History":
                            string procedureType = tokens[1];

                            result = this.animalCentre
                                .History(procedureType);
                            break;
                    }

                    this.writer.WriteLine(result);
                }
                catch (InvalidOperationException ioe)
                {
                    this.writer.WriteLine($"InvalidOperationException: {ioe.Message}");
                }
                catch (ArgumentException ae)
                {
                    this.writer.WriteLine($"ArgumentException: {ae.Message}");
                }

                input = this.reader.ReadLine();
            }

            if (this.animalCentre.AdoptedAnimals.Count > 0)
            {
                foreach (var adoptedAnimalInfo in this.animalCentre
                    .AdoptedAnimals
                    .OrderBy(a => a.Key))
                {
                    string owner = adoptedAnimalInfo.Key;
                    List<string> animals = adoptedAnimalInfo.Value;

                    this.writer.WriteLine(
                        string.Format(
                            ConstantMessages.OwnerName,
                            owner));
                    this.writer.WriteLine(
                        string.Format(
                            ConstantMessages.AdoptedAnimals,
                            string.Join(" ", animals)));
                }
            }
        }
    }
}
