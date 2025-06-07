using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyEfCoreApp.DbContexts;
using MyEfCoreApp.Models;
using MyEfCoreApp.WebApi;
using Xunit;

namespace TestMyEfCodeApp;
public class ProductsApiControllerTests
{
    private readonly ProductsApiController _controller;
    private readonly ApplicationDbContext _context;
    public ProductsApiControllerTests()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TestDatabase").Options;
        _context = new ApplicationDbContext(options);
        _controller = new ProductsApiController(_context);
    }

    [Fact]
    public async Task GetProducts_ReturnsOkResult_WithListOfProducts()
    {
        // Arrange
        var products = new List<Product>
        {
            new()
            {
                Id = 1,
                Name = "Product 1",
                Price = 9.99m
            },
            new()
            {
                Id = 2,
                Name = "Product 2",
                Price = 19.99m
            }
        };
        foreach (var product in products)
        {
            _context.Products.Add(product);
        }

        await _context.SaveChangesAsync();
        // Act
        var result = await _controller.GetProducts();
        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var returnProducts = Assert.IsType<List<Product>>(okResult.Value);
        Assert.Equal(2, returnProducts.Count());
    }
}