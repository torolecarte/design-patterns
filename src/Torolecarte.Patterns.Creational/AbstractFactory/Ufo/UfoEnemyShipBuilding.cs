using Torolecarte.Patterns.Creational.AbstractFactory.Enum;

namespace Torolecarte.Patterns.Creational.AbstractFactory.Ufo
{
    public class UfoEnemyShipBuilding : AbstractEnemyShipBuilding
    {
        // Methods.
        protected override AbstractEnemyShip Make(EEnemyShipTypes shipType)
        {
            switch (shipType)
            {
                case EEnemyShipTypes.Ufo:
                    return BuildUfo();
                    break;
                case EEnemyShipTypes.BigUfo:
                    return BuildBigUfo();
                    break;
                default:
                    Console.WriteLine("This type of ship is not supported");
                    return null;
                    break;
            }
        }

        
        // Private Methods.
        private AbstractEnemyShip BuildUfo()
        {
            IEnemyShipFactory factory = new UfoEnemyShipFactory();
            var enemyShip = new UfoEnemyShip(factory);

            return enemyShip;
        }
        private AbstractEnemyShip BuildBigUfo()
        {
            IEnemyShipFactory factory = new BigUfoEnemyShipFactory();
            var enemyShip = new BigUfoEnemyShip(factory);

            return enemyShip;
        }
    }
}
