using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
