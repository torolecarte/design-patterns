namespace Torolecarte.Patterns.Behavioral.Strategy.FireModes
{
    public sealed class AutomaticFireMode : AbstractFireMode
    {
        public AutomaticFireMode()
        {
            NumberOfShotsPerTriggerPull = -1;
        }

        public override void Shoot(string shotSound)
        {
            base.Shoot(shotSound);
            Console.Write("...");
            Console.WriteLine();
        }
    }
}
