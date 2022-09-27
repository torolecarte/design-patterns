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
