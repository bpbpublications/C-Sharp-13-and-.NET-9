int[] numbers =
{
    10,
    20,
    30,
    40,
    50
};
MathOperations math = new MathOperations();
var result = math.CalculateSumAndAverage(numbers);
Console.WriteLine($"Sum: {result.Item1}");
Console.WriteLine($"Average: {result.Item2}");