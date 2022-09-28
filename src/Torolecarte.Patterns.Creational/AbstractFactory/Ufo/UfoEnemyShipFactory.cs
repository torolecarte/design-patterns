using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torolecarte.Patterns.Creational.AbstractFactory.Ufo
{
    public class UfoEnemyShipFactory : IEnemyShipFactory
    {
        public AbstractEnemyShipEngine AddEngine()
        {
            return new UfoEngine();
        }

        public AbstractEnemyShipWeapon AddGun()
        {
            return new UfoGun();
        }
    }
}
