using Torolecarte.Patterns.Creational.AbstractFactory.Enum;

namespace Torolecarte.Patterns.Creational.AbstractFactory
{
    public abstract class AbstractEnemyShipBuilding
    {
        protected abstract AbstractEnemyShip Make(EEnemyShipTypes shipType);

        public AbstractEnemyShip OrderShip(EEnemyShipTypes shipType)
        {
            AbstractEnemyShip enemyShip = Make(shipType);

            enemyShip?.MakeShip();
            Console.WriteLine(enemyShip?.ToString());
            //enemyShip?.Display();
            //enemyShip?.FollowHero();
            //enemyShip?.Shoot();

            return enemyShip;
        }
    }
}
