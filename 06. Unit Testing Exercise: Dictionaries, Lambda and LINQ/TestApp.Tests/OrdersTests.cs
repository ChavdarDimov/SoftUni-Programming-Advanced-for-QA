using System;
using System.Text;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[0];

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 1.99 3", "banana 1.25 3", "orange 1.98 1", "apple 2 2" };
        StringBuilder sb = new();
        sb.AppendLine("apple -> 10.00");
        sb.AppendLine("banana -> 3.75");
        sb.AppendLine("orange -> 1.98");


        // Act
        string result = Orders.Order(input);
        string expected = sb.ToString().Trim();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 2.0000005 3", "banana 1.0000001 3", "orange 3.0000009 1" };
        StringBuilder sb = new();
        sb.AppendLine("apple -> 6.00");
        sb.AppendLine("banana -> 3.00");
        sb.AppendLine("orange -> 3.00");

        // Act
        string result = Orders.Order(input);
        string expected = sb.ToString().Trim();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 50.50 1000000.10", "banana 50.50 1000000.10", "orange 50.50 1000000.10" };
        StringBuilder sb = new();
        sb.AppendLine("apple -> 50500005.05");
        sb.AppendLine("banana -> 50500005.05");
        sb.AppendLine("orange -> 50500005.05");

        // Act
        string result = Orders.Order(input);
        string expected = sb.ToString().Trim();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithSingleOrder_ShouldReturnCorrectTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 2.5 5" };
        StringBuilder sb = new();
        sb.AppendLine("apple -> 12.50");

        // Act
        string result = Orders.Order(input);
        string expected = sb.ToString().Trim();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithZeroPrice_ShouldHandleCorrectly()
    {
        // Arrange
        string[] input = new string[] { "apple 0 10", "banana 1.25 3" };
        StringBuilder sb = new();
        sb.AppendLine("apple -> 0.00");
        sb.AppendLine("banana -> 3.75");

        // Act
        string result = Orders.Order(input);
        string expected = sb.ToString().Trim();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
