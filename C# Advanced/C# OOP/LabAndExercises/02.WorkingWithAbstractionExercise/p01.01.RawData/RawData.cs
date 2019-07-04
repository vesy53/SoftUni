namespace p01._01.RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RawData
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine()
                    .Split(new[] { ' ' }, 
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string model = parameters[0];
                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);
                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];
                double tire1Pressure = double.Parse(parameters[5]);
                int tire1age = int.Parse(parameters[6]);
                double tire2Pressure = double.Parse(parameters[7]);
                int tire2age = int.Parse(parameters[8]);
                double tire3Pressure = double.Parse(parameters[9]);
                int tire3age = int.Parse(parameters[10]);
                double tire4Pressure = double.Parse(parameters[11]);
                int tire4age = int.Parse(parameters[12]);

                Engine engine = new Engine(engineSpeed, enginePower);

                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Car car = new Car(model, engine, cargo);

                Tire[] tires = new Tire[4];
                tires[0] = new Tire(tire1Pressure, tire1age);
                tires[1] = new Tire(tire2Pressure, tire2age);
                tires[2] = new Tire(tire3Pressure, tire3age);
                tires[3] = new Tire(tire4Pressure, tire4age);

                car.Tires[0] = tires[0];
                car.Tires[1] = tires[1];
                car.Tires[2] = tires[2];
                car.Tires[3] = tires[3];

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                List<string> fragile = cars
                    .Where(x => x.Cargo.Type == "fragile" && 
                                x.Tires.Any(t => t.Pressure < 1))
                    .Select(x => x.Model)
                    .ToList();
                
                Console.WriteLine(
                    string.Join(
                        Environment.NewLine, fragile));
            }
            else
            {
                List<string> flamable = cars
                    .Where(x => x.Cargo.Type == "flamable" && 
                                x.Engine.Power > 250)
                    .Select(x => x.Model)
                    .ToList();
                
                Console.WriteLine(
                    string.Join(
                        Environment.NewLine, flamable));
            }
        }
    }
}
