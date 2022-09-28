namespace Torolecarte.Patterns.Creational.AbstractFactory.Ufo
{
    public sealed class UfoEnemyShip : AbstractEnemyShip
    {
        // Fields.
        private readonly IEnemyShipFactory factory;

        // Constructors.
        public UfoEnemyShip(IEnemyShipFactory factory)
        {
            this.factory = factory;
        }

        // Methods.
        public override void MakeShip()
        {
            Console.WriteLine($"Making enemy ship {Name}...");

            Weapon = factory.AddGun();
            Engine = factory.AddEngine();
        }
    }
}
