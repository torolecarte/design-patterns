using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torolecarte.Patterns.Creational.AbstractFactory.Rocket
{
    public class RocketEnemyShipFactory : IEnemyShipFactory
    {
        public AbstractEnemyShipEngine AddEngine()
        {
            return new RocketEngine();
        }
        public AbstractEnemyShipWeapon AddGun()
        {
            return new RocketMissile();
        }
    }
}
