int? num = null;
if (num.HasValue)
{
    Console.WriteLine($"Value is: {num.Value}");
}
else
{
    Console.WriteLine("No value present.");
}