public static class StringExtensions
{
    public static string AppendNumber(this string str, int number)
    {
        return str + number.ToString();
    }

    public static string AppendNumber(this string str, double number)
    {
        return str + number.ToString();
    }
}