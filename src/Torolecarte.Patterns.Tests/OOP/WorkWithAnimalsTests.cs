using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torolecarte.Patterns.OOP;

namespace Torolecarte.Patterns.Tests.OOP
{
    public class WorkWithAnimalsTests
    {
        [Test]
        public void AnimalsTests()
        {
            // Arrange.
            Animal dog = new Dog();
            Animal cat = new Cat();
            Animal wolf = new Wolf("Leader");

            List<Animal> animals = new List<Animal>() { dog, cat };
            animals.Add(wolf);

            // Act.
            foreach (var item in animals)
            {
                Console.WriteLine($"The {item.GetType().Name} sounds like: {item.Sound}");

                if (item.GetType() == typeof(Dog)
                    || item.GetType().IsSubclassOf(typeof(Dog)))
                {
                    Console.WriteLine("- Also it can:");

                    //Dog d = (Dog)item;
                    ((Dog)item).DigHole();

                    if (item.GetType() == typeof(Wolf))
                        ((Wolf)item).Howl();
                }
            }

            // Assert.
            Assert.That(true);
        }
    }
}
