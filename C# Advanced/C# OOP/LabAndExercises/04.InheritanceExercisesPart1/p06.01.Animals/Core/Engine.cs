namespace p06._01.Animals.Core
{
    using System;
    using System.Collections.Generic;
    
    using p06._01.Animals.Animals;
    using p06._01.Animals.Factories;

    public class Engine
    {
        private AnimalFactory animalFactory;
        private List<Animal> animals;

        public Engine()
        {
            this.animalFactory = new AnimalFactory();
            this.animals = new List<Animal>();
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
                string sound = animal.ProduceSound();

                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine(animal);
                Console.WriteLine(sound);
            }
        }
    }
}
