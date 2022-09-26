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
        public void PlayWithCatAndDog()
        {
            // Arrange.
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Act.
            dog.Name = "Fido";
            Console.WriteLine($"Dog's name: {dog.Name}");

            dog.DigHole();
            //dog.Weight = -1;




            // Assert.
            Assert.That(true);
        }
    }
}
