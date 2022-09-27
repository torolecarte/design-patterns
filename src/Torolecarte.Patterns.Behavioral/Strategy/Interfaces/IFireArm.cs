namespace Torolecarte.Patterns.Behavioral.Strategy.Interfaces
{
    public interface IFireArm
    {
        string ShotSound { get; }
        IFireMode FireMode { get; }

        void Shoot();
    }
}
