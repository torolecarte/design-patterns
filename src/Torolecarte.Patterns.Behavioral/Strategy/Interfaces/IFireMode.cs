﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torolecarte.Patterns.Behavioral.Strategy.Interfaces
{
    public interface IFireMode
    {
        int NumberOfShotsPerTriggerPull { get; }

        void Shoot(string shotSound);
    }
}
