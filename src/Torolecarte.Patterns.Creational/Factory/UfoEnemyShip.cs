using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torolecarte.Patterns.Creational.Factory
{
    public class UfoEnemyShip : AbstractEnemyShip
    {
        public UfoEnemyShip()
        {
            Name = "UFO Ship";
            Damage = 20.0F;
        }
    }
}
