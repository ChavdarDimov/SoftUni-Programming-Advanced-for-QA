using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string word = "";
        int rotator = 1;

        // Act
        string actual = StringRotator.RotateRight(word, rotator);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        string word = "hello";
        int rotator = 0;

        // Act
        string actual = StringRotator.RotateRight(word, rotator);

        // Assert
        Assert.That(actual, Is.EqualTo("hello"));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        string word = "abcdef";
        int rotator = 2;

        // Act
        string actual = StringRotator.RotateRight(word, rotator);

        // Assert
        Assert.That(actual, Is.EqualTo("efabcd"));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        string word = "12345";
        int rotator = -2;

        // Act
        string actual = StringRotator.RotateRight(word, rotator);

        // Assert
        Assert.That(actual, Is.EqualTo("45123"));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        string word = "xyz";
        int rotator = 5;

        // Act
        string actual = StringRotator.RotateRight(word, rotator);

        // Assert
        Assert.That(actual, Is.EqualTo("yzx"));
    }
}
