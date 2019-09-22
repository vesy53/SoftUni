namespace Telecom.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Tests
    {
        private const string Make = "Germany";
        private const string Model = "Nokia";

        private const string Name = "Gogo";
        private const string Number = "789456";

        private Phone phone;

        [SetUp]
        public void SetUp()
        {
            this.phone = new Phone(Make, Model);
        }

        [Test]
        public void ConstructorShouldInitializeCorrectly()
        {
            string expectedMake = Make;
            string actualMake = this.phone.Make;
            string expectedModel = Model;
            string actualModel = this.phone.Model;

            Assert.AreEqual(expectedMake, actualMake);
            Assert.AreEqual(expectedModel, actualModel);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void PropertyMakeWhenItIsNullOrEmptyShouldThrowArgumentException(
            string make)
        {
            Assert
            .Throws<ArgumentException>(
                () => new Phone(make, Model));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void PropertyModelWhenItIsNullOrEmptyShouldThrowArgumentException(
            string model)
        {
            Assert
             .Throws<ArgumentException>(
                 () => new Phone(Make, model));
        }

        [Test]
        public void AddContactShouldWorkCorrect()
        {
            this.phone.AddContact(Name, Number);

            int expectedCount = 1;
            int actualCount = this.phone.Count;

            Assert.That(expectedCount == actualCount);
        }

        [Test]
        public void AddContactShouldThrowInvalidOperationException()
        {
            this.phone.AddContact(Name, Number);

            Assert
                .Throws<InvalidOperationException>(
                    () => this.phone.AddContact(Name, Number));
        }

        [Test]
        public void CallShouldThrowInvalidOperationException()
        {
            Assert
                .Throws<InvalidOperationException>(
                    () => this.phone.Call(Name));
        }

        [Test]
        public void CallShouldWorcCorrect()
        {
            this.phone.AddContact(Name, Number);

            string expectedResult = $"Calling {Name} - {Number}...";
            string actualResult = this.phone.Call(Name);

            Assert.IsTrue(expectedResult == actualResult);
        }
    }
}