namespace p10._01.CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string model = tokens[0];
                int power = int.Parse(tokens[1]);

                Engine engine = new Engine(model, power);

                if (tokens.Length == 3)
                {
                    string input = tokens[2];

                    bool isDigit = int.TryParse(input, out int displacementNum);

                    if (isDigit)
                    {
                        engine.Displacement = input;
                    }
                    else
                    {
                        engine.Efficiency = input;
                    }
                }
                else if (tokens.Length == 4)
                {
                    string displacement = tokens[2];
                    string efficiency = tokens[3];

                    engine.Displacement = displacement;
                    engine.Efficiency = efficiency;
                }

                engines.Add(engine);
            }

            number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string model = tokens[0];
                string modelEngine = tokens[1];

                Engine searchEngine = engines
                    .Where(e => e.Model == modelEngine)
                    .FirstOrDefault();

                if (searchEngine != null)
                {
                    Car car = new Car(model, searchEngine);

                    if (tokens.Length == 3)
                    {
                        string input = tokens[2];

                        bool isDigit = int.TryParse(input, out int digit);

                        if (isDigit)
                        {
                            car.Weight = input;
                        }
                        else
                        {
                            car.Color = input;
                        }
                    }
                    else if (tokens.Length == 4)
                    {
                        string weight = tokens[2];
                        string color = tokens[3];

                        car.Weight = weight;
                        car.Color = color;
                    }

                    cars.Add(car);
                }
            }

            PrintResult(cars);
        }

        private static void PrintResult(List<Car> cars)
        {
            cars
                .ForEach(c => Console.WriteLine(c));
        }
    }
}
