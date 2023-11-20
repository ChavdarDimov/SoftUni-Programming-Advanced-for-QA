using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class CountRealNumbersTests
{

    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] count = new int[0];

        // Act
        string result = CountRealNumbers.Count(count);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] count = { 1 };
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("1 -> 1");

        // Act
        string result = CountRealNumbers.Count(count);
        string expected = sb.ToString().Trim();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        int[] count = { 1, 2, 3, 3 };
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("1 -> 1");
        sb.AppendLine("2 -> 1");
        sb.AppendLine("3 -> 2");

        // Act
        string result = CountRealNumbers.Count(count);
        string expected = sb.ToString().Trim();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        int[] count = { -1, -2, -3, -3 };
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("-3 -> 2");
        sb.AppendLine("-2 -> 1");
        sb.AppendLine("-1 -> 1");

        // Act
        string result = CountRealNumbers.Count(count);
        string expected = sb.ToString().Trim();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        int[] count = {0, 1, 2, 3, 3 };
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("0 -> 1");
        sb.AppendLine("1 -> 1");
        sb.AppendLine("2 -> 1");
        sb.AppendLine("3 -> 2");

        // Act
        string result = CountRealNumbers.Count(count);
        string expected = sb.ToString().Trim();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
