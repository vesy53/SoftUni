﻿namespace p02._02.CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CarSalesman
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();

            int engineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < engineCount; i++)
            {
                string[] parameters = Console.ReadLine()
                    .Split(new[] { ' ' }, 
                        StringSplitOptions
                        .RemoveEmptyEntries);
                string model = parameters[0];
                int power = int.Parse(parameters[1]);

                if (parameters.Length == 3)
                {
                    bool isDisplacement = int
                        .TryParse(parameters[2], out int displacement);

                    if (isDisplacement)
                    {
                        engines.Add(new Engine(model, power, displacement));
                    }
                    else 
                    {
                        string efficiency = parameters[2];

                        engines.Add(new Engine(model, power, efficiency));
                    }

                }
                else if (parameters.Length == 4)
                {
                    int displacement = int.Parse(parameters[2]);
                    string efficiency = parameters[3];

                    engines
                        .Add(new Engine(model, power, displacement, efficiency));
                }
                else
                {
                    engines.Add(new Engine(model, power));
                }
            }

            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                string[] parameters = Console.ReadLine()
                    .Split(new[] { ' ' }, 
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string model = parameters[0];
                string engineModel = parameters[1];

                Engine engine = engines
                    .FirstOrDefault(x => x.Model == engineModel);

                if (parameters.Length == 3)
                {
                    bool isWeight = int
                        .TryParse(parameters[2], out int weight);

                    if (isWeight)
                    {
                        cars.Add(new Car(model, engine, weight));
                    }
                    else 
                    {
                        string color = parameters[2];

                        cars.Add(new Car(model, engine, color));
                    }
                }
                else if (parameters.Length == 4)
                {
                    int weight = int.Parse(parameters[2]);
                    string color = parameters[3];

                    cars.Add(new Car(model, engine, weight, color));
                }
                else
                {
                    cars.Add(new Car(model, engine));
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
