using System;
using System.Collections.Generic;
using System.Linq;

class Animals2
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        List<Dog> dogs = new List<Dog>();
        List<Cat> cats = new List<Cat>();
        List<Snake> snakes = new List<Snake>();

        while (input != "I'm your Huckleberry")
        {
            string[] inputTokens = input
                .Split();

            if (inputTokens.Length == 2)
            {
                string animalName = inputTokens[1];
                string sound = string.Empty;

                if (dogs.Where(x => x.Name == animalName).Count() != 0)
                {
                    sound = "I'm a Distinguishedog, and I will now" +
                        " produce a distinguished sound! Bau Bau.";
                }
                else if (cats.Where(x => x.Name == animalName).Count() != 0)
                {
                    sound = "I'm an Aristocat, and I will now " +
                        "produce an aristocratic sound! Myau Myau.";
                }
                else if (snakes.Where(x => x.Name == animalName).Count() != 0)
                {
                    sound = "I'm a Sophistisnake, and I will now " +
                        "produce a sophisticated sound! Honey, I'm home.";
                }

                HelperAnimal.ProduceSound(sound);
                input = Console.ReadLine();
                continue;
            }

            string clas = inputTokens[0];
            string name = inputTokens[1];
            int age = int.Parse(inputTokens[2]);
            int parameter = int.Parse(inputTokens[3]);

            if (clas.Equals("Dog"))
            {
                Dog dog = new Dog
                {
                    Age = age,
                    Name = name,
                    NumberOfLegs = parameter
                };

                dogs.Add(dog);
            }
            else if (clas.Equals("Cat"))
            {
                Cat cat = new Cat
                {
                    Age = age,
                    Name = name,
                    IntelligenceQuotient = parameter
                };

                cats.Add(cat);
            }
            else
            {
                Snake snake = new Snake
                {
                    Age = age,
                    Name = name,
                    CrueltyCoefficient = parameter
                };

                snakes.Add(snake);
            }

            input = Console.ReadLine();
        }

        PrintDogs(dogs);
        PrintCats(cats);
        PrintSnakes(snakes);
    }

    static void PrintSnakes(List<Snake> snakes)
    {
        foreach (var snake in snakes)
        {
            string name = snake.Name;
            int age = snake.Age;
            int cruelty = snake.CrueltyCoefficient;

            Console.WriteLine(
                $"Snake: {name}, Age: {age}, Cruelty: {cruelty}");
        }
    }

    static void PrintCats(List<Cat> cats)
    {
        foreach (var cat in cats)
        {
            string name = cat.Name;
            int age = cat.Age;
            int IQ = cat.IntelligenceQuotient;

            Console.WriteLine(
                $"Cat: {name}, Age: {age}, IQ: {IQ}");
        }
    }

    static void PrintDogs(List<Dog> dogs)
    {
        foreach (var dog in dogs)
        {
            string name = dog.Name;
            int age = dog.Age;
            int numOfLegs = dog.NumberOfLegs;

            Console.WriteLine(
                $"Dog: {name}, Age: {age}, Number Of Legs: {numOfLegs}");
        }
    }
}

class HelperAnimal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public static void ProduceSound(string sound)
    {
        Console.WriteLine(sound);
    }
}

class Dog : HelperAnimal
{
    public int NumberOfLegs { get; set; }
}

class Cat : HelperAnimal
{
    public int IntelligenceQuotient { get; set; }
}

class Snake : HelperAnimal
{
    public int CrueltyCoefficient { get; set; }
}