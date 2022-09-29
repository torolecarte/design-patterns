namespace Torolecarte.Patterns.Creational.AbstractFactory.Ufo
{
    public class BigUfoEnemyShip : AbstractEnemyShip
    {
        // Fields.
        private readonly IEnemyShipFactory _factory;

        // Constructors.
        public BigUfoEnemyShip(IEnemyShipFactory factory)
        {
            this._factory = factory;
        }

        // Methods.
        public override void MakeShip()
        {
            Name = "Uber UFO Ship";
            Console.WriteLine($"Making enemy ship {Name}...");
            Weapon = _factory.AddGun();
            Engine = _factory.AddEngine();
        }
    }
}
