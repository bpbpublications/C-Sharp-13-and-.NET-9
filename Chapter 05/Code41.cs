decimal amount = 1234.56m;
string formattedAmount = amount.ToMoneyFormat();
Console.WriteLine(formattedAmount); // Outputs: $1,234.56
static class DecimalExtensions
{
    public static string ToMoneyFormat(this decimal amount)
    {
        return String.Format("{0:C}", amount);
    }
}