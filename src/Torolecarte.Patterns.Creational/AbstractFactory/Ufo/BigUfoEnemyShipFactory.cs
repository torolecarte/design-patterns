namespace Torolecarte.Patterns.Creational.AbstractFactory.Ufo
{
    public class BigUfoEnemyShipFactory : IEnemyShipFactory
    {
        public AbstractEnemyShipEngine AddEngine()
        {
            return new BigUfoEngine();
        }

        public AbstractEnemyShipWeapon AddGun()
        {
            return new BigUfoGun();
        }
    }
}
