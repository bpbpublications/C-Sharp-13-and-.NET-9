int x = int.MaxValue;
int y = unchecked(x + 1);
Console.WriteLine(y); // Output: -2147483648 (int.MinValue)
Console.ReadKey();