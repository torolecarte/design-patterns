using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Torolecarte.Patterns.Behavioral.Strategy.Interfaces;

namespace Torolecarte.Patterns.Behavioral.Strategy
{
    public abstract class AbstractSingleModeGun : IFireArm
    {
        public IFireMode FireMode { get; protected set; }
        public string ShotSound { get; protected set;}

        public AbstractSingleModeGun()
        {
        }

        public void Shoot()
        {
            FireMode.Shoot(ShotSound);
        }
    }
}
