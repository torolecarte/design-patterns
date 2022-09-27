namespace Torolecarte.Patterns.Behavioral.Observer.Interfaces
{
    public interface ISubject
    {
        List<IObserver> Observers { get; }

        void Register(IObserver o);
        void Unregister(IObserver o);
        void NotifyObservers();
    }
}
