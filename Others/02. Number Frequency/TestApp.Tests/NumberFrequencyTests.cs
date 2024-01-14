using System.Collections.Generic;
using NUnit.Framework;
using TestApp;

namespace TestApp.Tests
{
    [TestFixture]
    public class NumberFrequencyTests
    {
        [Test]
        public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
        {
            // Arrange
            int number = 0;
            var expected = new Dictionary<int, int>();

            // Act
            var result = NumberFrequency.CountDigits(number);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
        {
            // Arrange
            int number = 5;
            var expected = new Dictionary<int, int> { [5] = 1 };

            // Act
            var result = NumberFrequency.CountDigits(number);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
        {
            // Arrange
            int number = 112233;
            var expected = new Dictionary<int, int>
            {
                [1] = 2,
                [2] = 2,
                [3] = 2
            };

            // Act
            var result = NumberFrequency.CountDigits(number);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
        {
            // Arrange
            int number = -123454321;
            var expected = new Dictionary<int, int>
            {
                [1] = 2,
                [2] = 2,
                [3] = 2,
                [4] = 2,
                [5] = 1
            };

            // Act
            var result = NumberFrequency.CountDigits(number);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
