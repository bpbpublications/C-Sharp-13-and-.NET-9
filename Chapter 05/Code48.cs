Calculator calc = new Calculator();
Console.WriteLine(calc.Add(1, 2)); // Outputs: 3
Console.WriteLine(calc.Add(1.0f, 2.0f)); // Outputs: 3.0
Console.WriteLine(calc.Add(1, 2, 3)); // Outputs: 6
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public float Add(float a, float b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}