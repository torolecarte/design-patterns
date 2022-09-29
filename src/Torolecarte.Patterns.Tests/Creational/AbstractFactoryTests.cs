using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torolecarte.Patterns.Creational.AbstractFactory;
using Torolecarte.Patterns.Creational.AbstractFactory.Enum;
using Torolecarte.Patterns.Creational.AbstractFactory.Rocket;
using Torolecarte.Patterns.Creational.AbstractFactory.Ufo;

namespace Torolecarte.Patterns.Tests.Creational
{
    public class AbstractFactoryTests
    {
        // Ufo Building
        [Test]
        public void Order_UfoShipToUfoBuilding_ReturnsUfoShip()
        {
            // Arrange.
            AbstractEnemyShipBuilding building = new UfoEnemyShipBuilding();

            // Act.
            AbstractEnemyShip ship = building.OrderShip(EEnemyShipTypes.Ufo);

            // Assert.
            Assert.That(ship, Is.TypeOf<UfoEnemyShip>());
            Assert.That(ship.Weapon, Is.TypeOf<UfoGun>());
            Assert.That(ship.Engine, Is.TypeOf<UfoEngine>());
        }
        [Test]
        public void Order_BigUfoShipToUfoBuilding_ReturnsBigUfoShip()
        {
            // Arrange.
            AbstractEnemyShipBuilding building = new UfoEnemyShipBuilding();

            // Act.
            AbstractEnemyShip ship = building.OrderShip(EEnemyShipTypes.BigUfo);

            // Assert.
            Assert.That(ship, Is.TypeOf<BigUfoEnemyShip>());
            Assert.That(ship.Weapon, Is.TypeOf<BigUfoGun>());
            Assert.That(ship.Engine, Is.TypeOf<BigUfoEngine>());
        }
        [Test]
        public void Order_RocketShipToUfoBuilding_ReturnsNull()
        {
            // Arrange.
            AbstractEnemyShipBuilding building = new UfoEnemyShipBuilding();

            // Act.
            AbstractEnemyShip ship = building.OrderShip(EEnemyShipTypes.Rocket);

            // Assert.
            Assert.That(ship, Is.Null);
        }

        // Rocket Building
        [Test]
        public void Order_RocketShipToRocketShipBuilding_ReturnsRocketShip()
        {
            // Arrange.
            AbstractEnemyShipBuilding building = new RocketEnemyShipBuilding();

            // Act.
            AbstractEnemyShip ship = building.OrderShip(EEnemyShipTypes.Rocket);

            // Assert.
            Assert.That(ship, Is.TypeOf<RocketEnemyShip>());
            Assert.That(ship.Weapon, Is.TypeOf<RocketMissile>());
            Assert.That(ship.Engine, Is.TypeOf<RocketEngine>());
        }
        [Test]
        public void Order_UfoShipToRocketBuilding_ReturnsNull()
        {
            // Arrange.
            AbstractEnemyShipBuilding building = new RocketEnemyShipBuilding();

            // Act.
            AbstractEnemyShip ship = building.OrderShip(EEnemyShipTypes.Ufo);

            // Assert.
            Assert.That(ship, Is.Null);
        }
        [Test]
        public void Order_BigUfoShipToRocketBuilding_ReturnsNull()
        {
            // Arrange.
            AbstractEnemyShipBuilding building = new RocketEnemyShipBuilding();

            // Act.
            AbstractEnemyShip ship = building.OrderShip(EEnemyShipTypes.BigUfo);

            // Assert.
            Assert.That(ship, Is.Null);
        }
    }
}
