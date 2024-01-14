using NUnit.Framework;
using System;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;

    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }

    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arrange
        string productName = "TestProduct";
        double productPrice = 10.99;
        int productQuantity = 5;

        // Act
        _inventory.AddProduct(productName, productPrice, productQuantity);

        // Assert
        Assert.AreEqual(1, _inventory.DisplayInventory().Split('\n').Length - 1);
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // Act
        string result = _inventory.DisplayInventory();

        // Assert
        Assert.AreEqual("Product Inventory:", result);
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange
        _inventory.AddProduct("ProductA", 10.5, 2);
        _inventory.AddProduct("ProductB", 15.25, 3);

        // Act
        string result = _inventory.DisplayInventory();

        // Assert
        Assert.AreEqual($"Product Inventory:{Environment.NewLine}ProductA - Price: $10.50 - Quantity: 2{Environment.NewLine}ProductB - Price: $15.25 - Quantity: 3", result);
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // Act
        double result = _inventory.CalculateTotalValue();

        // Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        _inventory.AddProduct("ProductA", 10.5, 2);
        _inventory.AddProduct("ProductB", 15.25, 3);

        // Act
        double result = _inventory.CalculateTotalValue();

        // Assert
        Assert.AreEqual(10.5 * 2 + 15.25 * 3, result);
    }

    // Additional custom tests

    [Test]
    public void Test_AddMultipleProducts_DisplayInventory_ReturnsFormattedInventory()
    {
        // Arrange
        _inventory.AddProduct("ProductA", 10.5, 2);
        _inventory.AddProduct("ProductB", 15.25, 3);
        _inventory.AddProduct("ProductC", 8.0, 1);

        // Act
        string result = _inventory.DisplayInventory();

        // Assert
        Assert.AreEqual($"Product Inventory:{Environment.NewLine}ProductA - Price: $10.50 - Quantity: 2{Environment.NewLine}ProductB - Price: $15.25 - Quantity: 3{Environment.NewLine}ProductC - Price: $8.00 - Quantity: 1", result);
    }  


}
