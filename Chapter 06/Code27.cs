public static double SumStringsAsNumbers(string str1, string str2)
{
    if (double.TryParse(str1, out double num1) && double.TryParse(str2, out double num2))
    {
        return num1 + num2;
    }
    else
    {
        throw new ArgumentException("Both arguments must be convertible to a double.");
    }
}