namespace Torolecarte.Patterns.Creational.AbstractFactory.Ufo
{
    public sealed class UfoEnemyShip : AbstractEnemyShip
    {
        // Fields.
        private readonly IEnemyShipFactory _factory;

        // Constructors.
        public UfoEnemyShip(IEnemyShipFactory factory)
        {
            _factory = factory;
        }

        // Methods.
        public override void MakeShip()
        {
            Name = "UFO Annoying Ship";
            Console.WriteLine($"Making enemy ship {Name}...");
            Weapon = _factory.AddGun();
            Engine = _factory.AddEngine();
        }
    }
}
