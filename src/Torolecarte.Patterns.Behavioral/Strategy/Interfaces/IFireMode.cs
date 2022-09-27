namespace Torolecarte.Patterns.Behavioral.Strategy.Interfaces
{
    public interface IFireMode
    {
        int NumberOfShotsPerTriggerPull { get; }

        void Shoot(string shotSound);
    }
}
