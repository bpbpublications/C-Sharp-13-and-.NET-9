public static class StringExtensions
{
    public static string CapitalizeFirstLetter(this string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return str;
        }

        return $"{str[..1].ToString().ToUpper()}{str[1..]}";
    }
}