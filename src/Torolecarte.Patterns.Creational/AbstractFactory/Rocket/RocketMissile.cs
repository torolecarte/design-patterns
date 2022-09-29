using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torolecarte.Patterns.Creational.AbstractFactory.Rocket
{
    public class RocketMissile : AbstractEnemyShipWeapon
    {
        public override string ToString()
        {
            return "100 damage";
        }
    }
}
