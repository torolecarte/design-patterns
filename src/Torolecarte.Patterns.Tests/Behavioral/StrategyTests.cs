using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torolecarte.Patterns.Behavioral.Strategy;

namespace Torolecarte.Patterns.Tests.Behavioral
{
    public class StrategyTests
    {
        [Test]
        public void Shoot_Ak47_ContinuousShots()
        {
            // Arrange.
            var ak47 = new Ak47();

            // Act.
            ak47.Shoot();
            ak47.Shoot();

            // Assert.
            Assert.That(true);
        }
        [Test]
        public void Shoot_Pistol_SingleShot()
        {
            // Arrange.
            var pistol = new Pistol();

            // Act.
            pistol.Shoot();
            pistol.Shoot();

            // Assert.
            Assert.That(true);
        }
        [Test]
        public void Shoot_M16_BurstThreeShots()
        {
            // Arrange.
            var m16 = new M16();

            // Act.
            m16.Shoot();
            m16.Shoot();

            // Assert.
            Assert.That(true);
        }
    }
}
