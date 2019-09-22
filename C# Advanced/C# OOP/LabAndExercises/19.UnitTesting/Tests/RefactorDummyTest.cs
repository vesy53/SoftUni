namespace Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class RefactorDummyTest
    {
        private const int AxeAttackPoints = 5;
        private const int AxeDurabilityPoints = 5;
        private const int DummyHealth = 15;
        private const int DummyExperience = 15;

        private const int ExpectedAxeDurability = 4;
        private const int ExpectedDummyHealth = 10;

        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void StartUp()
        {
            this.axe = new Axe(AxeAttackPoints, AxeDurabilityPoints);
            this.dummy = new Dummy(DummyHealth, DummyExperience);
        }

        [Test]
        public void DummyLosesHealthIfAttackedAxe()
        {
            this.axe.Attack(this.dummy);

            int expectedDummyHealth = ExpectedDummyHealth;
            //int expectedDummyHealth = 0;
            int actualDummyHealth = this.dummy.Health;

            int expectedAxeDurability = ExpectedAxeDurability;
            //int expectedAxeDurability = 5;
            int actualAxeDurability = this.axe.DurabilityPoints;

            Assert.AreEqual(expectedDummyHealth, actualDummyHealth,
                "Dummy can't attack because is dead!!!");
            //Assert.That(actualDummyHealth, Is.EqualTo(ExpectedDummyHealth));
            //Assert.True(ExpectedDummyHealth == actualDummyHealth);

            Assert.AreEqual(expectedAxeDurability, actualAxeDurability,
                "Axe durability not decrease!");
            //Assert.That(actualAxeDurability, Is.EqualTo(expectedAxeDurability));
            //Assert.True(expectedAxeDurability == actualAxeDurability);

            Assert.Greater(actualDummyHealth, actualAxeDurability);
            //Assert.Greater(actualAxeDurability, actualDummyHealth,
            //    "Axe durability is not greater of dummy health!");
        }

        [Test]
        public void DeadDummyThrowsAnExceptionifAttacked()
        {
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    this.axe.Attack(this.dummy);
                }

                Assert.Fail("No exception thrown!");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is InvalidOperationException);
            }
        }

        [Test]
        [TestCase(0, 123)]
        [TestCase(0, 100)]
        public void DeadDummyThrowsAnExceptionifAttackedSecondTest(
            int healthDummy, 
            int experienceDummy)
        {
            this.dummy = new Dummy(healthDummy, experienceDummy);

            Assert.That(() => this.dummy.TakeAttack(1),
              Throws.InvalidOperationException
                    .With
                    .Message
                    .EqualTo("Dummy is dead."),
              "Dummy is not dead.");
        }

        [Test]
        [TestCase(0, DummyExperience)]
        public void DeadDummyCanGiveExperience(
            int healthDummy,
            int experienceDummy)
        {
            this.dummy = new Dummy(healthDummy, experienceDummy);

            int expectedExperience = DummyExperience;
            int actualExperience = dummy.GiveExperience();

            Assert.AreEqual(expectedExperience, actualExperience,
                "Alive dummy can give experience!");
        }

        [Test]
        public void AliveDummyCantGiveExperience()
        {
            //this.dummy = new Dummy(0, DummyExperience);

            Assert.That(() => this.dummy.GiveExperience(),
                Throws.InvalidOperationException
                   .With
                   .Message
                   .EqualTo("Target is not dead."),
                "Dummy is dead.");
        }

        [TearDown]  //executes after each test
        public void CleanUp()
        {

        }
    }
}
