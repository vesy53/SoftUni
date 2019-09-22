﻿namespace Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class HeroTests
    {
        private const string HeroName = "Pesho";

        [Test]
        public void HeroGainsExperienceAfterAttackIfTargetDies()
        {
            // Arrange
            ITarget fakeTarget = new FakeTarget();
            IWeapon fakeWeapon = new FakeWeapon();
            Hero hero = new Hero(HeroName, fakeWeapon);

            // Act
            hero.Attack(fakeTarget);

            // Assert
            Assert.That(hero.Experience, Is.EqualTo(20));
        }
    }
}
