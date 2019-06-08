namespace p08._01.RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string model = tokens[0];
                int engineSpeed = int.Parse(tokens[1]);
                int enginePower = int.Parse(tokens[2]);
                int cargoWeight = int.Parse(tokens[3]);
                string cargoType = tokens[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);

                Car car = new Car(model, engine, cargo);
                int index = 0;

                for (int j = 5; j < tokens.Length; j += 2)
                {
                    double pressure = double.Parse(tokens[j]);
                    int age = int.Parse(tokens[j + 1]);

                    Tire tire = new Tire(age, pressure);

                    car.Tires[index] = tire;
                    index++;
                }

                cars.Add(car);
            }

            string searchCargoType = Console.ReadLine();

            Func<string, bool> isFragile = f => f.Equals("fragile");
            List<string> result = new List<string>();

            if (isFragile(searchCargoType))
            {
                result = cars
                    .Where(x => x.Cargo.Type == searchCargoType &&
                                x.Tires.Any(t => t.Pressure < 1))
                    .Select(x => x.Model)
                    .ToList();

                //second method
                //cars
                //    .Where(c => c.Cargo.Type == "fragile" && 
                //                c.Tires.Any(t => t.Pressure < 1))
                //    .ToList()
                //    .ForEach(c => Console.WriteLine($"{c.Model}"));
            }
            else
            {
                result = cars
                    .Where(x => x.Cargo.Type == searchCargoType &&
                                x.Engine.Power > 250)
                    .Select(x => x.Model)
                    .ToList();
            }

            Console.WriteLine(
                string.Join(Environment.NewLine, result));
        }
    }
}
