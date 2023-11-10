using NUnit.Framework;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace TestApp.UnitTests;

public class PatternTests
{

    [TestCase("a", 3, "aaa")]
    [TestCase("a", 4, "aaaa")]
    [TestCase("a", 5, "aaaaa")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = "";
        int repetitionFactor = 3;

        // Assert
        Assert.That(()=> Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException.With.Message.EqualTo("Input string cannot be empty, and repetition factor must be positive."));
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "a";
        int repetitionFactor = -3;

        // Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException.With.Message.EqualTo("Input string cannot be empty, and repetition factor must be positive."));
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "a";
        int repetitionFactor = 0;

        // Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException.With.Message.EqualTo("Input string cannot be empty, and repetition factor must be positive."));
    }
}
