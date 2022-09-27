using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torolecarte.Patterns.Behavioral.Strategy.FireModes;

namespace Torolecarte.Patterns.Behavioral.Strategy
{
    public class Pistol : AbstractSingleModeGun
    {
        public Pistol()
        {
            FireMode = new SemiAutomaticFireMode();
            ShotSound = "Pew";
        }
    }
}
