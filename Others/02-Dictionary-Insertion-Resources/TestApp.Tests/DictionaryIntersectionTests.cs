using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> emptyDict1 = new Dictionary<string, int>();
        Dictionary<string, int> emptyDict2 = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(emptyDict1, emptyDict2);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> emptyDict = new Dictionary<string, int>();
        Dictionary<string, int> nonEmptyDict = new Dictionary<string, int>
            {
                { "A", 1 },
                { "B", 2 }
            };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(emptyDict, nonEmptyDict);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>
            {
                { "A", 1 },
                { "B", 2 }
            };

        Dictionary<string, int> dict2 = new Dictionary<string, int>
            {
                { "C", 3 },
                { "D", 4 }
            };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>
            {
                { "A", 1 },
                { "B", 2 },
                { "C", 3 }
            };

        Dictionary<string, int> dict2 = new Dictionary<string, int>
            {
                { "B", 2 },
                { "C", 3 },
                { "D", 4 }
            };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.AreEqual(2, result.Count);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>
            {
                { "A", 1 },
                { "B", 2 },
                { "C", 3 }
            };

        Dictionary<string, int> dict2 = new Dictionary<string, int>
            {
                { "B", 20 },
                { "C", 30 },
                { "D", 4 }
            };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.IsEmpty(result);
    }
}
