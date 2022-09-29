namespace Torolecarte.Patterns.Creational.AbstractFactory.Rocket
{
    public class RocketEnemyShipFactory : IEnemyShipFactory
    {
        public AbstractEnemyShipEngine AddEngine()
        {
            return new RocketEngine();
        }
        public AbstractEnemyShipWeapon AddGun()
        {
            return new RocketMissile();
        }
    }
}
