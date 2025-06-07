using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;

[TestClass]
public class MyTests
{
    [TestMethod]
    public void TestAddition()
    {
        // Arrange
        var a = 5;
        var b = 10;
        // Act
        var result = a + b;
        // Assert
        Assert.AreEqual(15, result);
    }
}