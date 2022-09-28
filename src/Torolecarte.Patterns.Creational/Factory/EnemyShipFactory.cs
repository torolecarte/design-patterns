using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Torolecarte.Patterns.Creational.Factory.Enum;

namespace Torolecarte.Patterns.Creational.Factory
{
    public class EnemyShipFactory
    {
        public AbstractEnemyShip MakeEnemyShip(EEnemyShipTypes shipType)
        {
            switch (shipType)
            {
                case EEnemyShipTypes.Rocket:
                    return new RocketEnemyShip();
                    break;
                case EEnemyShipTypes.UFO:
                    return new UfoEnemyShip();
                    break;
                case EEnemyShipTypes.BigUFO:
                    return new BigUfoEnemyShip();
                    break;
                default:
                    return null;
                    break;
            }
        }
    }
}
