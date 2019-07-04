namespace NeedForSpeed.Core
{
    using System;

    using NeedForSpeed.Vehicles.Cars;
    using NeedForSpeed.Vehicles.Motorcycles;

    public class Engine
    {
        public void Run()
        {
            FamilyCar familyCar = new FamilyCar(100, 25.60);
            SportCar sportCar = new SportCar(45, 190);
            CrossMotorcycle crossMotorcycle = new CrossMotorcycle(200, 56.30);
            RaceMotorcycle raceMotorcycle = new RaceMotorcycle(250, 90.99);

            familyCar.Drive(5);
            sportCar.Drive(10);
            crossMotorcycle.Drive(25);
            raceMotorcycle.Drive(2);

            Console.WriteLine(familyCar);
            Console.WriteLine(sportCar);
            Console.WriteLine(crossMotorcycle);
            Console.WriteLine(raceMotorcycle);
        }
    }
}
