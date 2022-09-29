using Torolecarte.Patterns.Creational.AbstractFactory.Enum;

namespace Torolecarte.Patterns.Creational.AbstractFactory.Rocket
{
    public class RocketEnemyShipBuilding : AbstractEnemyShipBuilding
    {
        protected override AbstractEnemyShip Make(EEnemyShipTypes shipType)
        {
            switch (shipType)
            {
                case EEnemyShipTypes.Rocket:
                    return new RocketEnemyShip(new RocketEnemyShipFactory());
                    break;
                default:
                    Console.WriteLine("This type of ship is not supported");
                    return null;
                    break;
            }
        }
    }
}
