using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torolecarte.Patterns.Behavioral.Strategy.FireModes;
using Torolecarte.Patterns.Behavioral.Strategy.Interfaces;

namespace Torolecarte.Patterns.Behavioral.Strategy
{
    public class Ak47 : AbstractSingleModeGun
    {
        public Ak47()
        {
            FireMode = new AutomaticFireMode();
            ShotSound = "Ta!";
        }
    }
}
