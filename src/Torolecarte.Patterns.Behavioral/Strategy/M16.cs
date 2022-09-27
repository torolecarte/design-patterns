using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torolecarte.Patterns.Behavioral.Strategy.FireModes;

namespace Torolecarte.Patterns.Behavioral.Strategy
{
    public class M16 : AbstractSingleModeGun
    {
        public M16()
        {
            FireMode = new BurstFireMode();
            ShotSound = "Pew!";
        }
    }
}
