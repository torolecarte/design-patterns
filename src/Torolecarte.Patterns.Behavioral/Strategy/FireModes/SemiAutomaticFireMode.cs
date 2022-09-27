using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torolecarte.Patterns.Behavioral.Strategy.Interfaces;

namespace Torolecarte.Patterns.Behavioral.Strategy.FireModes
{
    public sealed class SemiAutomaticFireMode : AbstractFireMode
    {
        public SemiAutomaticFireMode()
        {
            NumberOfShotsPerTriggerPull = 1;
        }

        public override void Shoot(string shotSound)
        {
            base.Shoot(shotSound);
            Console.WriteLine();
        }
    }
}
