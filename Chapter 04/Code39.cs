using NUnit.Framework;

[TestFixture]
public class MathOperationsTests
{
    private MathOperations math;
    [SetUp]
    public void SetUp()
    {
        // This method runs before each test.
        math = new MathOperations();
    }

    [Test]
    public void Add_TwoPositiveIntegers_ReturnsSum()
    {
        // Arrange
        int a = 5;
        int b = 3;
        // Act
        int result = math.Add(a, b);
        // Assert
        Assert.AreEqual(8, result);
    }

    [Test]
    public void Subtract_TwoPositiveIntegers_ReturnsDifference()
    {
        // Arrange
        int a = 10;
        int b = 4;
        // Act
        int result = math.Subtract(a, b);
        // Assert
        Assert.AreEqual(6, result);
    }
}