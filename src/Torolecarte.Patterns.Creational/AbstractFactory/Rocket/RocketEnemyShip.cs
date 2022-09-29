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
            Console.WriteLine($"Making enemy ship {Name}");

            this.Name = "Stupendous Rocket";
            this.Weapon = _factory.AddGun();
            this.Engine = _factory.AddEngine();
        }
    }
}
