using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torolecarte.Patterns.Behavioral.Observer.Interfaces
{
    public interface IObserver
    {
        void Update(string stockName, decimal price);
        void Update(decimal ibmPrice, decimal aaplPrice, decimal googPrice);
    }
}
