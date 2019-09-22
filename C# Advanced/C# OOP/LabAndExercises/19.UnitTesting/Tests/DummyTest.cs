namespace Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DummyTest
    {
        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            //Axe(int attack, int durability)
            //Dummy(int health, int experience)

            /*in class Axe => Attack(Dummy target)
            target.TakeAttack(this.attackPoints);
            this.durabilityPoints -= 1;*/

            /* in class Dummy => TakeAttack(int attackPoints)
            this.health -= attackPoints;*/

            Axe axe = new Axe(5, 5);
            Dummy dummy = new Dummy(15, 15);

            axe.Attack(dummy);

            int expectedDummyHealth = 10;
            int actualDummyHealth = dummy.Health;

            int expectedAxeDurability = 4;
            int actualAxeDurability = axe.DurabilityPoints;

            Assert.AreEqual(expectedDummyHealth, actualDummyHealth);
            Assert.That(actualDummyHealth, Is.EqualTo(expectedDummyHealth));
            Assert.True(expectedDummyHealth == actualDummyHealth);

            Assert.AreEqual(expectedAxeDurability, actualAxeDurability);
            Assert.That(actualAxeDurability, Is.EqualTo(expectedAxeDurability));
            Assert.True(expectedAxeDurability == actualAxeDurability);

            Assert.Greater(actualDummyHealth, actualAxeDurability);
            Assert.Less(expectedAxeDurability, expectedDummyHealth);

            Assert.Positive(actualAxeDurability);
            Assert.Positive(actualDummyHealth);

            Assert.False(actualDummyHealth == expectedAxeDurability);
        }

        [Test]
        public void DeadDummyThrowsAnExceptionifAttacked()
        {
            try
            {
                Axe axe = new Axe(5, 5);
                Dummy dummy = new Dummy(10, 10);

                for (int i = 0; i < 3; i++)
                {
                    axe.Attack(dummy);
                }

                Assert.Fail("No exception thrown!");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is InvalidOperationException);
            }
        }

        [Test]
        public void DeadDummyThrowsAnExceptionifAttackedSecondTest()
        {
            Axe axe = new Axe(5, 5);
            Dummy dummy = new Dummy(0, 10);

            Assert
                .Throws<InvalidOperationException>(
                    () => axe.Attack(dummy));
        }

        [Test]
        public void DeadDummyCanGivXP()
        {
            Dummy dummy = new Dummy(0, 10);

            int expectedExperience = 10;
            int actualExperience = dummy.GiveExperience();

            int health = dummy.Health;

            Assert.AreEqual(expectedExperience, actualExperience);
            Assert.Zero(health);
        }

        [Test]
        public void AliveDummyCantGiveXp()
        {
            Dummy dummy = new Dummy(10, 10);

            Assert
               .Throws<InvalidOperationException>(
                    () => dummy.GiveExperience());
        }
    }
}
