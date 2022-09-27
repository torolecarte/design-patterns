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
