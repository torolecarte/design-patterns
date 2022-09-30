using Torolecarte.Patterns.Creational.Singleton;

namespace Torolecarte.Patterns.Tests.Creational
{
    public class SingletonTests
    {
        [Test]
        public void GetTiles_RequestThreeTiles_ReturnsRandomizedThreeTiles()
        {
            // Arrange.
            int countExpected = 3;
            var instance = ScrabbleSingleton.Instance;

            // Act.
            var result = instance.GetLetterTiles(countExpected);
            Console.WriteLine("First result: " + String.Join(", ", result));

            result = instance.GetLetterTiles(countExpected);
            Console.WriteLine("Second result: " + String.Join(", ", result));

            // Assert.
            Assert.That(result.Count, Is.EqualTo(countExpected));
            Assert.That(instance.AllLettersInBag.Count - (countExpected * 2), Is.EqualTo(instance.AvailableLetters.Count));
        }
    }
}
