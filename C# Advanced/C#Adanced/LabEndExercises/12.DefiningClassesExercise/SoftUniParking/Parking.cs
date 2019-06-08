namespace SoftUniParking
{
    using System.Collections.Generic;
    using System.Linq;

    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;

            this.cars = new List<Car>();
        }

        public int Count => this.cars.Count();

        public string AddCar(Car car)
        {
            bool isExist = this.cars
                .Any(c => c.RegistrationNumber == car.RegistrationNumber);

            if (isExist)
            {
                return "Car with that registration number, already exists!";
            }

            if (this.cars.Count >= this.capacity)
            {
                return "Parking is full!";
            }

            this.cars.Add(car);

            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {
            Car car = this.cars
                .Where(c => c.RegistrationNumber == registrationNumber)
                .FirstOrDefault();

            if (car == null)
            {
                return "Car with that registration number, doesn't exist!";
            }

            this.cars.Remove(car);

            return $"Successfully removed {registrationNumber}";
        }

        public Car GetCar(string registrationNumber)
        {
            Car car = this.cars
               .Where(c => c.RegistrationNumber == registrationNumber)
               .FirstOrDefault();

            return car;
        }

        public void RemoveSetOfRegistrationNumber(
            List<string> registrationNumbers)
        {
            foreach (string currentNumber in registrationNumbers)
            {
                this.cars
                    .RemoveAll(c => c.RegistrationNumber == currentNumber);
            }
        }
    }
}
