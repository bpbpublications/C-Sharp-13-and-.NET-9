using NUnit.Framework;
using System;

[TestFixture]
public class MathOperationsTests
{
    [Test]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        MathOperations math = new MathOperations();
        Assert.Throws<DivideByZeroException>(() => math.Divide(10, 0));
    }
}