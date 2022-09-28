using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Torolecarte.Patterns.Creational.AbstractFactory
{
    public abstract class AbstractEnemyShip
    {
        // Properties.
        public string Name { get; set; }
        public AbstractEnemyShipWeapon Weapon { get; set; }
        public AbstractEnemyShipEngine Engine { get; set; }

        // Methods.
        public abstract void MakeShip();

        // Overrides.
        public override string ToString()
        {
            string info = $"{Name}: has a top speed of {Engine} and an attack power of {Weapon}";
            return info;
        }
    }
}
