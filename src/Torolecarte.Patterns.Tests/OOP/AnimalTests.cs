using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torolecarte.Patterns.OOP;

namespace Torolecarte.Patterns.Tests.OOP
{
    public class AnimalTests
    {
        [Test]
        public void SetWeight_Equal10_Returns10()
        {
            // Arrange.
            var animal = new Animal();
            int expectedWeight = 10;

            // Act.
            animal.Weight = expectedWeight;

            // Assert.
            Assert.That(expectedWeight, Is.EqualTo(animal.Weight));
        }
        [Test]
        public void SetWeight_LessOrEqualToZero_ThrowsArgumentOutOfRangeException()
        {
            // Arrange.
            var animal = new Animal();
            int errorWeight = 0;

            // Act.
            Action act = () => animal.Weight = errorWeight;

            // Assert.
            Assert.That(act, Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
