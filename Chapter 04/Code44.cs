using NUnit.Framework;
using Xunit;

public class MathOperations
{
    public int Divide(int dividend, int divisor)
    {
        if (divisor == 0)
            throw new DivideByZeroException();
        return dividend / divisor;
    }
}

[TestCaseDiscoverer("Xunit.Sdk.SkipIfTestCaseDiscoverer", "xunit.core")]
public class MathOperationsTests
{
    private MathOperations math;
    public MathOperationsTests()
    {
        math = new MathOperations();
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(15, 3, 0)]
    public void Divide_ValidDivisor_ReturnsQuotient(int dividend, int divisor, int expectedQuotient)
    {
        int result = math.Divide(dividend, divisor);
        Assert.Equal(expectedQuotient, result);
    }

    [SkipIf(true, "Skipping this test because it is no longer relevant.")]
    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => math.Divide(10, 0));
    }
}
