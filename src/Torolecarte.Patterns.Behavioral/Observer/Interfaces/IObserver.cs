namespace Torolecarte.Patterns.Behavioral.Observer.Interfaces
{
    public interface IObserver
    {
        void Update(string stockName, decimal price);
        void Update(decimal ibmPrice, decimal aaplPrice, decimal googPrice);
    }
}
