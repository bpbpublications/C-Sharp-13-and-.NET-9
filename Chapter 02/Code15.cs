int x = 10;
// y gets a copy of the value of x
int y = x;
// Modifying x doesn't affect y
x = 20;
// Output: 20
Console.WriteLine(x);
// Output: 10
Console.WriteLine(y);
Console.ReadKey();