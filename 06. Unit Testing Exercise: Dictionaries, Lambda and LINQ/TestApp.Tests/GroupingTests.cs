using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class GroupingTests
{
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> input = new();

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new() { 9, 10, 3, 4, 6 };

        StringBuilder sb = new();
        sb.AppendLine("Odd numbers: 9, 3");
        sb.AppendLine("Even numbers: 10, 4, 6");

        string expectedResult = sb.ToString().Trim();

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new() { 10, 4, 6, 800 };

        StringBuilder sb = new();
        sb.AppendLine("Even numbers: 10, 4, 6, 800");

        string expectedResult = sb.ToString().Trim();

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new() { 999, 1, 7, 201 };

        StringBuilder sb = new();
        sb.AppendLine("Odd numbers: 999, 1, 7, 201");

        string expectedResult = sb.ToString().Trim();

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new() { -999, 1, 2, 7, 201, 10, -4, 6, 800, 4, 999, -7, 666, -666 };

        StringBuilder sb = new();
        sb.AppendLine("Odd numbers: -999, 1, 7, 201, 999, -7");
        sb.AppendLine("Even numbers: 2, 10, -4, 6, 800, 4, 666, -666");

        string expectedResult = sb.ToString().Trim();

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}