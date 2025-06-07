using Xunit;

public class MathOperations
{
    public int Subtract(int a, int b)
    {
        return a - b;
    }
}

public class MathOperationsTests
{
    [Theory]
    [InlineData(8, 3, 5)]
    [InlineData(10, 6, 4)]
    [InlineData(15, 8, 7)]
    public void Subtract_TwoIntegers_ReturnsDifference(int expected, int a, int b)
    {
        MathOperations math = new MathOperations();
        int result = math.Subtract(a, b);
        Assert.Equal(expected, result);
    }
}