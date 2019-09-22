using NUnit.Framework;
using System;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddRider_Should_AddSuccesfully()
        {
            //Arrange
            RaceEntry raceEntry = new RaceEntry();
            UnitMotorcycle unitMotorcycle = new UnitMotorcycle("Honda", 70, 550);
            UnitRider unitRider = new UnitRider("Gogo", unitMotorcycle);

            // Act
            string actualMessage = raceEntry.AddRider(unitRider);
            string expectedMeessage = "Rider Gogo added in race.";

            // Assert
            Assert.AreEqual(expectedMeessage, actualMessage);
            Assert.AreEqual(raceEntry.Counter, 1);
        }

        [Test]
        public void AddRider_Should_ThrowInvalidOperationExceptionIfNull()
        {
            // Arrange
            RaceEntry raceEntry = new RaceEntry();

            // Act
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(
                    () => raceEntry.AddRider(null));

            string expectedMessage = "Rider cannot be null.";

            // Assert
            Assert.AreEqual(expectedMessage, exception.Message);
        }

        [Test]
        public void AddRider_Should_ThrowInvalidOperationExceptionIfRiderAlreadyExists()
        {
            //Arrange
            RaceEntry raceEntry = new RaceEntry();
            UnitMotorcycle unitMotorcycle = new UnitMotorcycle("Honda", 70, 550);
            UnitRider unitRider = new UnitRider("Gogo", unitMotorcycle);

            // Act
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(
                    () => raceEntry.AddRider(unitRider));

            string expectedMessage = "Rider Gogo is already added.";

            // Assert
            Assert.AreEqual(expectedMessage, exception.Message);
        }

        [Test]
        public void CalculateAverageHorsePower_Should_ReturnAverageHorsePowerOfAllRiders()
        {
            //Arrange
            RaceEntry raceEntry = new RaceEntry();

            UnitMotorcycle unitMotorcycle1 = new UnitMotorcycle("Honda", 70, 550);
            UnitRider unitRider1 = new UnitRider("Gogo", unitMotorcycle1);

            UnitMotorcycle unitMotorcycle2 = new UnitMotorcycle("Jamaha", 80, 650);
            UnitRider unitRider2 = new UnitRider("Pesho", unitMotorcycle2);

            UnitMotorcycle unitMotorcycle3 = new UnitMotorcycle("Kavazaki", 90, 700);
            UnitRider unitRider3 = new UnitRider("Tony", unitMotorcycle3);

            raceEntry.AddRider(unitRider1);
            raceEntry.AddRider(unitRider2);
            raceEntry.AddRider(unitRider3);

            double result = raceEntry.CalculateAverageHorsePower();

            double expectedResult = 50;

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CalculateAverageHorsePower_Should_ReturnInvalidoperationExceptionWhenOnly2RideraAreAdded()
        {
            //Arrange
            RaceEntry raceEntry = new RaceEntry();

            UnitMotorcycle unitMotorcycle1 = new UnitMotorcycle("Honda", 70, 550);
            UnitRider unitRider1 = new UnitRider("Gogo", unitMotorcycle1);

            raceEntry.AddRider(unitRider1);

            // Act
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(
                    () => raceEntry.CalculateAverageHorsePower());

            string expectedMessage = "The race cannot start with less than 2 participants.";

            // Assert
            Assert.AreEqual(expectedMessage, exception.Message);
        }

    }
}