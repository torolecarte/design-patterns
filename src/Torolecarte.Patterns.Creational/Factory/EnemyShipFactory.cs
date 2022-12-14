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
