namespace Torolecarte.Patterns.Creational.AbstractFactory.Rocket
{
    public class RocketEnemyShip : AbstractEnemyShip
    {
        private readonly RocketEnemyShipFactory _factory;

        public RocketEnemyShip(RocketEnemyShipFactory factory)
        {
            _factory = factory;
        }

        public override void MakeShip()
        {
            this.Name = "Stupendous Rocket";
            Console.WriteLine($"Making enemy ship {Name}");
            this.Weapon = _factory.AddGun();
            this.Engine = _factory.AddEngine();
        }
    }
}
