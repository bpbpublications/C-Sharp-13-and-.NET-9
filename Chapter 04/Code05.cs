ProcessNumbers(5, 3, Multiply);
// Function that takes two integers and a function as parameters
static void ProcessNumbers(int a, int b, Func<int, int, int> operation)
{
    int result = operation(a, b);
    Console.WriteLine("Result: " + result);
}

// Function that multiplies two integers
static int Multiply(int x, int y)
{
    return x * y;
}

