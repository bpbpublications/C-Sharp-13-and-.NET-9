public static double SumObjectsAsNumbers(object obj1, object obj2)
{
    if (obj1 is string str1 && double.TryParse(str1, out double num1) && obj2 is string str2 && double.TryParse(str2, out double num2))
    {
        return num1 + num2;
    }
    else
    {
        throw new ArgumentException("Both arguments must be convertible to a double.");
    }
}