namespace ParkingSystem.Tests
{
    using NUnit.Framework;
    using System.Collections.Generic;

    public class SoftParkTest
    {
        private const string Make = "France";
        private const string RegistrationNumber = "789456132";

        private const string InvalidParkSpot = "D7";
        private const string ValidParkSpot = "A1";
        private const string NewValidParkSpot = "B1";

        private Car car;
        private SoftPark softPark;

        [SetUp]
        public void Setup()
        {
            this.car = new Car(Make, RegistrationNumber);
            this.softPark = new SoftPark();
        }

        [Test]
        public void CarConstructorShouldInitializeCorrect()
        {
            string expectedMake = Make;
            string actualMake = this.car.Make;

            string expectedRegistrationNumber = RegistrationNumber;
            string actualRegistrationNumber = this.car.RegistrationNumber;

            Assert.That(expectedMake == actualMake);
            Assert.AreEqual(expectedRegistrationNumber, actualRegistrationNumber);
        }

        [Test]
        public void SoftUniConstructorShouldInitializeCorrect()
        {
            int expectedCount = 12;
            int actualCount = this.softPark.Parking.Count;

            List<string> expectedKeys = new List<string>()
            {
                "A1", "A2", "A3", "A4",
                "B1", "B2", "B3", "B4",
                "C1", "C2", "C3", "C4",
            };

            var actualKeys = this.softPark.Parking.Keys;

            Assert.AreEqual(expectedCount, actualCount);
            CollectionAssert.AreEquivalent(expectedKeys, actualKeys);
        }

        [Test]
        public void TestParkCarWhenParkingSpotDoesntExistShouldThrowArgumentException()
        {
            Assert.That(() => this.softPark.ParkCar(InvalidParkSpot, this.car),
                Throws
                .ArgumentException
                .With
                .Message
                .EqualTo("Parking spot doesn't exists!"));
        }

        [Test]
        public void TestParkCarWhenParkingSpotIsTakenShouldThrowArgumentException()
        {
            this.softPark.ParkCar(ValidParkSpot, this.car);

            Assert.That(() => this.softPark.ParkCar(ValidParkSpot, this.car),
                Throws
                .ArgumentException
                .With
                .Message
                .EqualTo("Parking spot is already taken!"));
        }

        [Test]
        public void TestParkCarWhenCarIsParkedTakenShouldThrowInvalidOperationException()
        {
            this.softPark.ParkCar(ValidParkSpot, this.car);

            Assert.That(() => this.softPark.ParkCar(NewValidParkSpot, this.car),
                Throws
                .InvalidOperationException
                .With
                .Message
                .EqualTo("Car is already parked!"));
        }

        [Test]
        public void TestParkCarWhenWorkCorrect()
        {
            string expectedResult = 
                $"Car:{this.car.RegistrationNumber} parked successfully!";
            string actualResult = this.softPark.ParkCar(ValidParkSpot, this.car);

            Assert.IsTrue(expectedResult == actualResult);
        }

        [Test]
        public void TestRemoveCarWhenParkingSpotDoesntExistShouldThrowArgumentException()
        {
            Assert.That(() => this.softPark.RemoveCar(InvalidParkSpot, this.car),
                Throws
                .ArgumentException
                .With
                .Message
                .EqualTo("Parking spot doesn't exists!"));
        }

        [Test]
        public void TestRemoveCarWhenCarInParkSpotDoesntExistShouldThrowArgumentException()
        {
            Assert.That(() => this.softPark.RemoveCar(ValidParkSpot, this.car),
                Throws
                .ArgumentException
                .With
                .Message
                .EqualTo("Car for that spot doesn't exists!"));
        }

        [Test]
        public void TestRemoveCarShouldWorkCorrect()
        {
            this.softPark.ParkCar(ValidParkSpot, this.car);

            string expectedResult = 
                $"Remove car:{this.car.RegistrationNumber} successfully!";
            string actualResult = this.softPark.RemoveCar(ValidParkSpot, this.car);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}