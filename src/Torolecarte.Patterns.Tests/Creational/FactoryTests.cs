using Torolecarte.Patterns.Creational.Factory;
using Torolecarte.Patterns.Creational.Factory.Enum;

namespace Torolecarte.Patterns.Tests.Creational
{
    public class FactoryTests
    {
        [Test]
        public void Make_UfoShipType_ReturnsUfoEnemyShip()
        {
            // Arrange.
            var factory = new EnemyShipFactory();

            // Act.
            var ship = factory.MakeEnemyShip(EEnemyShipTypes.UFO);

            // Assert.
            Assert.That(ship, Is.TypeOf<UfoEnemyShip>());
        }
        [Test]
        public void Make_BigUfoShipType_ReturnsBigUfoEnemyShip()
        {
            // Arrange.
            var factory = new EnemyShipFactory();

            // Act.
            var ship = factory.MakeEnemyShip(EEnemyShipTypes.BigUFO);

            // Assert.
            Assert.That(ship, Is.TypeOf<BigUfoEnemyShip>());
        }
        [Test]
        public void Make_RocketShipType_ReturnsRocketEnemyShip()
        {
            // Arrange.
            var factory = new EnemyShipFactory();

            // Act.
            var ship = factory.MakeEnemyShip(EEnemyShipTypes.Rocket);

            // Assert.
            Assert.That(ship, Is.TypeOf<RocketEnemyShip>());
        }
    }
}
