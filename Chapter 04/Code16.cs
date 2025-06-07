Func<int, int> doubleNumber = delegate (int x)
{
    return x * 2;
};
Console.WriteLine(doubleNumber(4)); // Outputs: 8
