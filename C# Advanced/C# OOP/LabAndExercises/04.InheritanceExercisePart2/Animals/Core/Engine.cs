namespace Animals.Core
{
    using System;
    using System.Collections.Generic;

    using Animals.HomesAnimals;
    using Animals.HomesAnimals.Factories;

    public class Engine
    {
        private List<Animal> animals;
        private AnimalFactory animalFactory;

        public Engine()
        {
            this.animals = new List<Animal>();
            this.animalFactory = new AnimalFactory();
        }

        public void Run()
        {
            string type = Console.ReadLine();

            while (type.Equals("Beast!") == false)
            {
                try
                {
                    string[] token = Console.ReadLine()
                        .Split();

                    string name = token[0];
                    int age = int.Parse(token[1]);
                    string gender = token[2];

                    Animal animal = animalFactory
                        .CreateAnimal(type, name, age, gender);

                    animals.Add(animal);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                type = Console.ReadLine();
            }

            Print();
        }

        private void Print()
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
