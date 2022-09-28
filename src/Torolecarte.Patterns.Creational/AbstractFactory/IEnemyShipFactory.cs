﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torolecarte.Patterns.Creational.AbstractFactory
{
    public interface IEnemyShipFactory
    {
        AbstractEnemyShipWeapon AddGun();
        AbstractEnemyShipEngine AddEngine();
    }
}
