using System.Globalization;

public class Product
{
    private decimal price;
    public string Price
    {
        get
        {
            return $"${price:0.00}";
        }

        set
        {
            price = decimal.Parse(value, NumberStyles.Currency);
        }
    }
}