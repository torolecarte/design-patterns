namespace Torolecarte.Patterns.Creational.AbstractFactory
{
    public interface IEnemyShipFactory
    {
        AbstractEnemyShipWeapon AddGun();
        AbstractEnemyShipEngine AddEngine();
    }
}
