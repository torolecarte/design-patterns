using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torolecarte.Patterns.Behavioral.Observer.Interfaces;

namespace Torolecarte.Patterns.Behavioral.Observer.StockPrices
{
    public class StockObserver : IObserver
    {
        // Static Fields.
        private static int _observerIdTracker = 0;

        // Fields.
        private Dictionary<string, decimal> _stockPrices = new();

        // Properties.
        private int _observerId;
        private ISubject _stockGrabber;

        // Constructors.
        public StockObserver(ISubject stockGrabber)
        {
            _observerId = ++StockObserver._observerIdTracker;
            _stockGrabber = stockGrabber;
            _stockGrabber.Register(this);
        }

        // Methods.
        public void Update(string stockName, decimal newPrice)
        {
            Update(stockName, newPrice);
            PrintPrices();
        }
        public void Update(decimal ibmPrice, decimal aaplPrice, decimal googPrice)
        {
            Update(StockNamesConstants.GOOGLE, googPrice, printPrices: false);
            Update(StockNamesConstants.APPLE, aaplPrice, printPrices: false);
            Update(StockNamesConstants.IBM, ibmPrice, printPrices: false);

            PrintPrices();
        }


        // Private Methods.
        private void Update(string stockName, decimal newPrice, bool printPrices = true)
        {
            if (_stockPrices.TryGetValue(stockName, out decimal currentPrice))
                _stockPrices[stockName] = newPrice;
            else
                _stockPrices.Add(stockName, newPrice);

            if (printPrices)
                PrintPrices();
        }
        private void PrintPrices()
        {
            Console.WriteLine($"# Observer ID: {this._observerId}");
            foreach (var price in _stockPrices)
            {
                Console.WriteLine($"{price.Key}: {price.Value.ToString("c")}");
            }
        }
    }
}
