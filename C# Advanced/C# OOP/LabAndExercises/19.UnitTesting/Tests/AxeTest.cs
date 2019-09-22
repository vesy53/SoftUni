namespace Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            //Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            //Act
            axe.Attack(dummy);

            int expectedDurability = 9;
            int actualDurability = axe.DurabilityPoints;

            //Assert
            Assert
                .That(actualDurability, Is.EqualTo(expectedDurability));
            
        }

        [Test]
        public void AttackingWithABrokenWeapon()
        {
            //Arrange
            Axe axe = new Axe(1, 1);
            Dummy dummy = new Dummy(10, 10);

            //Act
            axe.Attack(dummy);

            //Assert
            Assert.That(
                () => axe.Attack(dummy),
                Throws
                    .InvalidOperationException
                    .With
                    .Message
                    .EqualTo("Axe is broken."));

            Assert
                .Throws<InvalidOperationException>(
                    () => axe.Attack(dummy));
            Assert
                .Throws(
                    typeof(InvalidOperationException), 
                    () => axe.Attack(dummy));
        }

        [TestCase(1, 1)]
        //[TestCase(10, 0)]
        //[TestCase(5, -5)]
        public void AttackingWithABrokenWeaponSecond(int attack, int durability)
        {
            //Arrange
            Axe axe = new Axe(attack, durability);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.That(
                () => axe.Attack(dummy),
                Throws
                    .InvalidOperationException
                    .With
                    .Message
                    .EqualTo("Axe is broken."));
        }
    }
}
