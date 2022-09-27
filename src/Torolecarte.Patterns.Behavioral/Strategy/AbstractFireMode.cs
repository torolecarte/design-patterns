using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torolecarte.Patterns.Behavioral.Strategy.Interfaces;

namespace Torolecarte.Patterns.Behavioral.Strategy
{
    public abstract class AbstractFireMode : IFireMode
    {

        public int NumberOfShotsPerTriggerPull { get; protected set; }

        public AbstractFireMode()
        {
        }

        public virtual void Shoot(string shotSound)
        {
            int numberOfShots = (NumberOfShotsPerTriggerPull > -1 ? NumberOfShotsPerTriggerPull : 10);

            for (int i = 0; i < numberOfShots; i++)
            {
                Console.Write(shotSound);
            }
        }
    }
}
