using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }


    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() { "" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "h" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("h -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "aaa", "aabbccc", "ababcba" };
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("a -> 8");
        sb.AppendLine("b -> 5");
        sb.AppendLine("c -> 4");

        // Act
        string result = CountCharacters.Count(input);
        string expected = sb.ToString().Trim();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "aaa", "aabbccc", "ababcba!" };
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("a -> 8");
        sb.AppendLine("b -> 5");
        sb.AppendLine("c -> 4");
        sb.AppendLine("! -> 1");

        // Act
        string result = CountCharacters.Count(input);
        string expected = sb.ToString().Trim();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
