using Xunit;

[Trait("Category", "Math")]
public class MathOperationsTests
{
    private MathOperations math;
    public MathOperationsTests()
    {
        // This constructor runs before each test.
        math = new MathOperations();
    }

    [Fact]
    public void Add_TwoPositiveIntegers_ReturnsSum()
    {
        // Arrange
        int a = 5;
        int b = 3;
        // Act
        int result = math.Add(a, b);
        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void Subtract_TwoPositiveIntegers_ReturnsDifference()
    {
        // Arrange
        int a = 10;
        int b = 4;
        // Act
        int result = math.Subtract(a, b);
        // Assert
        Assert.Equal(6, result);
    }
}