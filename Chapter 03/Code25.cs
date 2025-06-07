int? x = 10;
int? y = null;
int? z = null;
Console.WriteLine($"{x} >= null is {x >= null}");
Console.WriteLine($"{x} < null is {x < null}");
Console.WriteLine($"{x} == null is {x == null}");
Console.WriteLine($"null >= null is {y >= z}");
Console.WriteLine($"null == null is {y == z}");