using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int> fruitDictionary = new Dictionary<string, int>
            {
                { "Apple", 5 },
                { "Orange", 10 },
                { "Banana", 8 }
            };
        string fruitName = "Orange";
        int expectedQuantity = 10;

        // Act
        int actualQuantity = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.AreEqual(expectedQuantity, actualQuantity);
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitDictionary = new Dictionary<string, int>
            {
                { "Apple", 5 },
                { "Orange", 10 },
                { "Banana", 8 }
            };
        string fruitName = "Grapes";
        int expectedQuantity = 0;

        // Act
        int actualQuantity = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.AreEqual(expectedQuantity, actualQuantity);
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitDictionary = new Dictionary<string, int>();
        string fruitName = "Apple";
        int expectedQuantity = 0;

        // Act
        int actualQuantity = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.AreEqual(expectedQuantity, actualQuantity);
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruitDictionary = null;
        string fruitName = "Apple";
        int expectedQuantity = 0;

        // Act
        int actualQuantity = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.AreEqual(expectedQuantity, actualQuantity);
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitDictionary = new Dictionary<string, int>
            {
                { "Apple", 5 },
                { "Orange", 10 },
                { "Banana", 8 }
            };
        string? fruitName = null;
        int expectedQuantity = 0;

        // Act
        int actualQuantity = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.AreEqual(expectedQuantity, actualQuantity);
    }
}
