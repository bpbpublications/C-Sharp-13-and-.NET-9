int[] numbers = new int[]
{
    0,
    1,
    2,
    3,
    4,
    5,
    6,
    7,
    8,
    9
};
ProcessSpan(numbers);
ProcessMemory(numbers);
Lazy<ExpensiveResource> lazyResource = new Lazy<ExpensiveResource>();
lazyResource.Value.DoWork();
static void ProcessSpan(int[] numbers)
{
    // Convert the array into a Span
    Span<int> span = numbers;
    // Slice the span to get a subset. This does not allocate a new array.
    Span<int> slicedSpan = span.Slice(2, 5); // start at 2nd element and take 5 elements: {2, 3, 4, 5, 6}
    Console.WriteLine("Processing Span:");
    foreach (var number in slicedSpan)
    {
        Console.WriteLine(number);
    }
}

static void ProcessMemory(int[] numbers)
{
    // Convert the array into Memory
    Memory<int> memory = numbers;
    // Slice the Memory to get a subset. This does not allocate a new array.
    Memory<int> slicedMemory = memory.Slice(5, 3); // start at 5th element and take 3 elements: {5, 6, 7}
    Console.WriteLine("\nProcessing Memory:");
    foreach (var number in slicedMemory.Span) // You access the span of the memory to enumerate it
    {
        Console.WriteLine(number);
    }
}

public class ExpensiveResource
{
    public ExpensiveResource()
    {
        Console.WriteLine("ExpensiveResource is being initialized...");
    }

    public void DoWork()
    {
        Console.WriteLine("ExpensiveResource is working...");
    }
}