using NUnit.Framework;

public class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

[TestFixture]
public class MathOperationsTests
{
    [Test]
    public void Add_TwoPositiveIntegers_ReturnsSum()
    {
        MathOperations math = new MathOperations();
        int result = math.Add(3, 5);
        Assert.AreEqual(8, result);
    }
}