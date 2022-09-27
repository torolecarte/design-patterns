using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torolecarte.Patterns.Behavioral.Observer.Interfaces;

namespace Torolecarte.Patterns.Behavioral.Observer.StockPrices
{
    public class StockGrabber : ISubject
    {
        // Fields.
        private Dictionary<string, decimal> _stockPrices = new();

        // Properties.
        public List<IObserver> Observers { get; private set; } = new();

        // Constructors.
        public StockGrabber()
        {
        }

        // Methods.
        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                _stockPrices.TryGetValue(StockNamesConstants.IBM, out decimal ibmPrice);
                _stockPrices.TryGetValue(StockNamesConstants.APPLE, out decimal applePrice);
                _stockPrices.TryGetValue(StockNamesConstants.GOOGLE, out decimal googlePrice);

                observer.Update(ibmPrice, applePrice, googlePrice);
            }
        }
        public void Register(IObserver o)
        {
            Observers.Add(o);
        }
        public void Unregister(IObserver o)
        {
            Observers.Remove(o);
        }

        public void SetGooglePrice(decimal price)
        {
            SetStockPrice(StockNamesConstants.GOOGLE, price);
        }
        public void SetApplePrice(decimal price)
        {
            SetStockPrice(StockNamesConstants.APPLE, price);
        }
        public void SetIbmPrice(decimal price)
        {
            SetStockPrice(StockNamesConstants.IBM, price);
        }


        // Private Methods.
        private void SetStockPrice(string stockName, decimal newPrice)
        {
            if (_stockPrices.TryGetValue(stockName, out decimal currentPrice))
                _stockPrices[stockName] = newPrice;
            else
                _stockPrices.Add(stockName, newPrice);

            NotifyObservers();
        }
    }
}
