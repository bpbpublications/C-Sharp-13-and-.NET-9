using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyEfCoreApp.Models;
using Xunit;

namespace TestMyEfCodeApp;
public class ProductTests
{
    [Fact]
    public void Product_SetGet_ReturnsExpectedValues()
    {
        // Arrange
        var product = new Product();
        // Act
        product.Id = 1;
        product.Name = "Test Product";
        product.Price = 9.99m;
        // Assert
        Assert.Equal(1, product.Id);
        Assert.Equal("Test Product", product.Name);
        Assert.Equal(9.99m, product.Price);
    }

    [Fact]
    public void Product_Constructor_SetsExpectedValues()
    {
        // Arrange
        var expectedId = 1;
        var expectedName = "Test Product";
        var expectedPrice = 9.99m;
        // Act
        var product = new Product
        {
            Id = expectedId,
            Name = expectedName,
            Price = expectedPrice
        };
        // Assert
        Assert.Equal(expectedId, product.Id);
        Assert.Equal(expectedName, product.Name);
        Assert.Equal(expectedPrice, product.Price);
    }
}