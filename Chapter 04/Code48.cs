using System;

public class MathOperations
{
    public Tuple<int, double> CalculateSumAndAverage(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        double average = (double)sum / numbers.Length;
        return Tuple.Create(sum, average);
    }
}