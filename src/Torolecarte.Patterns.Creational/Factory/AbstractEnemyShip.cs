namespace Torolecarte.Patterns.Creational.Factory
{
    public class AbstractEnemyShip
    {
        // Properties.
        public string Name { get; set; }
        public float Damage { get; set; }

        // Methods.
        public void FollowHeroShip()
        {
            Console.WriteLine($"{Name} is following the hero.");
        }
        public void DisplayEnemyShip()
        {
            Console.WriteLine($"{Name} is on the screen.");
        }
        public void Shoots()
        {
            Console.WriteLine($"{Name} is attacking and does {Damage}.");
        }
    }
}
