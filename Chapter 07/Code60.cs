enum Colors
{
    Red = 1,
    Green = 2,
    Blue = 4
};
Console.WriteLine(String.Format("{0:G}", Colors.Red)); // Outputs "Red"
Console.WriteLine(String.Format("{0:D}", Colors.Red)); // Outputs "1"
Console.WriteLine(String.Format("{0:X}", Colors.Red)); // Outputs "01"
