namespace Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class RefactorAxeTest
    {
        private const int AxeAttackPoints = 5;
        private const int AxeDurabilityPoints = 5;
        private const int DummyHealth = 10;
        private const int DummyExperience = 10;

        private const int ExpectedDurabilityWeapon = 4;
        private const int ExpectedBrokenWeapon = 3;

        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void SetUp()
        {
            this.axe = new Axe(AxeAttackPoints, AxeDurabilityPoints);
            this.dummy = new Dummy(DummyHealth, DummyExperience);
        }

        [Test]
        public void WeaponLosesDurabilityAfterAttack()
        {
            this.axe.Attack(this.dummy);

            int expectedResult = ExpectedDurabilityWeapon;
            int actualResult = this.axe.DurabilityPoints;

            Assert.That(expectedResult == actualResult,
                "Axe doesn't lose durability after attack!");
        }


        [Test]
        public void AxeAttackingWithABrokenWeapon()
        {
            for (int i = 0; i < 2; i++)
            {
                this.axe.Attack(this.dummy);
            }

            int expectedResult = ExpectedBrokenWeapon;
            // int expectedResult = 0;
            int actualResult = this.axe.DurabilityPoints;

            Assert.AreEqual(expectedResult, actualResult,
                "Axe doesn't attacking with broken weapon!");
        }

        [TearDown]  //executes after each test
        public void CleanUp()
        {

        }
    }
}
