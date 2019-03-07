using System;
using System.Collections.Generic;
using System.Linq;

class Animals
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

            string clas = inputTokens[0];

            if (clas == "Dog")
            {
                Dog dogInformation = new Dog
                {
                    Name = inputTokens[1],
                    Age = int.Parse(inputTokens[2]),
                    NumberOfLegs = int.Parse(inputTokens[3])
                };

                dogs.Add(dogInformation);
            }
            else if (clas == "Cat")
            {
                Cat catInformation = new Cat
                {
                    Name = inputTokens[1],
                    Age = int.Parse(inputTokens[2]),
                    IntelligenceQuotient = int.Parse(inputTokens[3])
                };

                cats.Add(catInformation);
            }
            else if (clas == "Snake")
            {
                Snake snakeInformation = new Snake
                {
                    Name = inputTokens[1],
                    Age = int.Parse(inputTokens[2]),
                    CrueltyCoefficient = int.Parse(inputTokens[3])
                };

                snakes.Add(snakeInformation);
            }
            else if (clas == "talk")
            {
                string name = inputTokens[1];

                if (dogs.Any(x => x.Name == name))
                {
                    Dog instance = new Dog();

                    instance.ProduceSound();
                }
                else if (cats.Any(x => x.Name == name))
                {
                    Cat instance = new Cat();

                    instance.ProduceSound();
                }
                else if (snakes.Any(x => x.Name == name))
                {
                    Snake instance = new Snake();

                    instance.ProduceSound();
                }
            }

            input = Console.ReadLine();
        }

        foreach (var dog in dogs)
        {
            string name = dog.Name;
            int age = dog.Age;
            int numberOfLegs = dog.NumberOfLegs;

            Console.WriteLine(
                $"Dog: {name}, Age: {age}, Number Of Legs: {numberOfLegs}");
        }

        foreach (var cat in cats)
        {
            string name = cat.Name;
            int age = cat.Age;
            int IQ = cat.IntelligenceQuotient;

            Console.WriteLine(
                $"Cat: {name}, Age: {age}, IQ: {IQ}");
        }

        foreach (var snake in snakes)
        {
            string name = snake.Name;
            int age = snake.Age;
            int cruelty = snake.CrueltyCoefficient;

            Console.WriteLine(
                $"Snake: {name}, Age: {age}, Cruelty: {cruelty}");
        }
    }
}
class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int NumberOfLegs { get; set; }

    public void ProduceSound()
    {
        Console.WriteLine(
            "I'm a Distinguishedog, and I will now " +
            "produce a distinguished sound! Bau Bau.");
    }
}

class Cat
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int IntelligenceQuotient { get; set; }

    public void ProduceSound()
    {
        Console.WriteLine(
            "I'm an Aristocat, and I will now produce" +
            " an aristocratic sound! Myau Myau.");
    }
}

class Snake
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int CrueltyCoefficient { get; set; }

    public void ProduceSound()
    {
        Console.WriteLine("I'm a Sophistisnake, and I will " +
            "now produce a sophisticated sound! Honey, I'm home.");
    }
}