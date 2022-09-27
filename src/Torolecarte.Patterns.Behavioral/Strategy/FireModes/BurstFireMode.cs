using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torolecarte.Patterns.Behavioral.Strategy.Interfaces;

namespace Torolecarte.Patterns.Behavioral.Strategy.FireModes
{
    public sealed class BurstFireMode : AbstractFireMode
    {
        public BurstFireMode()
        {
            NumberOfShotsPerTriggerPull = 3;
        }
        public override void Shoot(string shotSound)
        {
            base.Shoot(shotSound);
            Console.Write("...");
        }
    }
}
