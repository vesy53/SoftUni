using NUnit.Framework;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private const string Model = "Jamaha";
        private const int HorsePower = 50;
        private const double CubicCentimeters = 450;

        private const string RiderName = "Michael";
        private const string NewRiderName = "Tony";
        private const string NewModel = "Honda";
        private const int MinParticipants = 2;
        private const int AverageHorsePower = 50;

        private UnitMotorcycle motorcycle;
        private UnitRider rider;
        private RaceEntry raceEntry;

        [SetUp]
        public void Setup()
        {
            this.motorcycle = new UnitMotorcycle(
                Model,
                HorsePower,
                CubicCentimeters);

            this.rider = new UnitRider(RiderName, motorcycle);

            this.raceEntry = new RaceEntry();
        }

        [Test]
        public void TestRaceEntryCtorShouldInitializeCorrectly()
        {
            int actualCount = this.raceEntry.Counter;

            Assert.Zero(actualCount);
        }

        [Test]
        public void TestMethodAddRiderWhenAddedNUllRiderShouldThrowException()
        {
            Assert.That(
                () => this.raceEntry.AddRider(null),
                Throws
                .InvalidOperationException
                .With
                .Message
                .EqualTo("Rider cannot be null."));
        }

        [Test]
        public void TestMethodAddRiderWhenAddedExistingRiderNameShouldThrowException()
        {
            this.raceEntry.AddRider(this.rider);

            Assert.That(
               () => this.raceEntry.AddRider(this.rider),
               Throws
               .InvalidOperationException
               .With
               .Message
               .EqualTo($"Rider {RiderName} is already added."));
        }

        //[Test]
        //public void TestMethodAddRiderWhenAddedRiderCorectly()
        //{
        //    string expectedResult = $"Rider {RiderName} added in race.";
        //
        //    string actualResult = this.raceEntry.AddRider(this.rider);
        //
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        [Test]
        public void CalcAverageHorsePowerWhenRidersCountIsLessThanTwoShouldThrowException()
        {
            this.raceEntry.AddRider(this.rider);

            Assert.That(
               () => this.raceEntry.CalculateAverageHorsePower(),
               Throws
               .InvalidOperationException
               .With
               .Message
               .EqualTo($"The race cannot start with less than {MinParticipants} participants."));
        }

        [Test]
        public void CalcAverageHorsePowerWhenRidersCountIsGreaterThanTwoShouldThrowException()
        {
            this.raceEntry.AddRider(this.rider);

            this.motorcycle = new UnitMotorcycle(NewModel, HorsePower, CubicCentimeters);
            this.rider = new UnitRider(NewRiderName, motorcycle);

            this.raceEntry.AddRider(this.rider);

            double expectedResult = AverageHorsePower;
            double actualResult = this.raceEntry
                .CalculateAverageHorsePower();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}