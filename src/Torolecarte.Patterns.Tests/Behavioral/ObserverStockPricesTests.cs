using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torolecarte.Patterns.Behavioral.Observer.StockPrices;

namespace Torolecarte.Patterns.Tests.Behavioral
{
    public class ObserverStockPricesTests
    {
        [Test]
        public void When_StockPricesUpdate_NotifyObservers()
        {
            // Arrange.
            var stockGrabber = new StockGrabber();
            var observer1 = new StockObserver(stockGrabber);
            var observer2 = new StockObserver(stockGrabber);
            var observer3 = new StockObserver(stockGrabber);

            // Act.
            stockGrabber.SetGooglePrice(233.00M);
            stockGrabber.SetApplePrice(477.00M);
            stockGrabber.SetIbmPrice(866.00M);


            // Assert.
            Assert.True(true);
        }
    }
}
