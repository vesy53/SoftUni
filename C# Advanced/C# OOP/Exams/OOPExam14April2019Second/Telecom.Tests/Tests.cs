namespace Telecom.Tests
{
    using NUnit.Framework;
    using System;

    public class Tests
    {
        private const string Make = "Japan";
        private const string Model = "Samsung";

        private const string Name = "Dido";
        private const string Number = "123456";
        private const string NonExistingName = "Gogo";

        private Phone phone;

        [SetUp]
        public void SetUp()
        {
            this.phone = new Phone(Make, Model);
        }

        [Test]
        public void ConstructorShouldInitializeCorrectlt()
        {
            string expectedMake = Make;
            string actualMake = this.phone.Make;

            string expectedModel = Model;
            string actualModel = this.phone.Model;

            int expectedCount = 0;
            int actualCount = this.phone.Count;

            Assert.AreEqual(expectedMake, actualMake);
            Assert.IsTrue(expectedModel == actualModel);
            Assert.That(expectedCount == actualCount);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void PropertyMakeWhenItIsNullOrEmptyShouldThrowArgumentException(
            string make)
        {
            Assert.Throws<ArgumentException>(
                () => new Phone(make, Model));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void PropertyModleWhenItIsNullOrEmptyShouldThrowArgumentException(
            string model)
        {
            Assert.Throws<ArgumentException>(
                () => new Phone(Make, model));
        }

        [Test]
        public void AddContactShouldWorkCorrectly()
        {
            this.phone.AddContact(Name, Number);

            int actualCount = this.phone.Count;

            Assert.Positive(actualCount);
        }

        [Test]
        public void AddContactShouldThrowInvalidOperationException()
        {
            this.phone.AddContact(Name, Number);

            Assert.Throws<InvalidOperationException>(
                () => this.phone.AddContact(Name, Number));
        }

        [Test]
        public void CallShouldThrowInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(
               () => this.phone.Call(NonExistingName));
        }

        [Test]
        public void CallShouldWorkCorrect()
        {
            this.phone.AddContact(Name, Number);

            string expectedResult = $"Calling {Name} - {Number}...";
            string actualResult = this.phone.Call(Name);

            Assert.True(expectedResult == actualResult);
        }
    }
}