using Torolecarte.Patterns.Behavioral.Strategy.FireModes;

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
