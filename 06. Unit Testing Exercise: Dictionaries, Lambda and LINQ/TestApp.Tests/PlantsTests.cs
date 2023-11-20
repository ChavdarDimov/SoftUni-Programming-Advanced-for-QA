using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] plants = new string[0];

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }


    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = new string[] { "Lily" };
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Plants with 4 letters:");
        sb.AppendLine("Lily");

        // Act
        string result = Plants.GetFastestGrowing(plants);
        string expected = sb.ToString().Trim();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = new string[] { "Lily", "Rose", "Bamboo" };
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Plants with 4 letters:");
        sb.AppendLine("Lily");
        sb.AppendLine("Rose");
        sb.AppendLine("Plants with 6 letters:");
        sb.AppendLine("Bamboo");

        // Act
        string result = Plants.GetFastestGrowing(plants);
        string expected = sb.ToString().Trim();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = new string[] { "lilY", "roSe", "BAMboo" };
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Plants with 4 letters:");
        sb.AppendLine("lilY");
        sb.AppendLine("roSe");
        sb.AppendLine("Plants with 6 letters:");
        sb.AppendLine("BAMboo");

        // Act
        string result = Plants.GetFastestGrowing(plants);
        string expected = sb.ToString().Trim();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
