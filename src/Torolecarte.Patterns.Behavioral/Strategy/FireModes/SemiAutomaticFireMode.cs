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
