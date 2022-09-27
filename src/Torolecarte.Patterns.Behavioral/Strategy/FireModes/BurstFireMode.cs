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
