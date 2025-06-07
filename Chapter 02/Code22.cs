string str = "10";
if (int.TryParse(str, out var result))
{
    // Output 10
    Console.WriteLine(result);
}