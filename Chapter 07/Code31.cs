var dictionary = new Dictionary<string, string>
{
    {
        "key1",
        "value1"
    },
    {
        "key2",
        "value2"
    }
};
Console.WriteLine($"Dictionary: {string.Join(", ", dictionary)}");
// Queue<T>
var queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
Console.WriteLine($"Queue (after two enqueues): {string.Join(", ", queue)}");
int dequeuedValue = queue.Dequeue();
Console.WriteLine($"Dequeued from Queue: {dequeuedValue}");
// Stack<T>
var stack = new Stack<int>();
stack.Push(3);
stack.Push(4);
Console.WriteLine($"Stack (after two pushes): {string.Join(", ", stack)}");
int poppedValue = stack.Pop();
Console.WriteLine($"Popped from Stack: {poppedValue}");
// HashSet<T>
var hashSet = new HashSet<int>
{
    5,
    6,
    6
}; // Adding duplicate value 6, but HashSet will filter it out
Console.WriteLine($"HashSet: {string.Join(", ", hashSet)}");
// LinkedList<T>
var linkedList = new LinkedList<string>();
linkedList.AddLast("firstElement");
linkedList.AddLast("secondElement");
Console.WriteLine($"LinkedList: {string.Join(", ", linkedList)}");
// SortedSet<T>
var sortedSet = new SortedSet<int>
{
    8,
    7,
    9
}; // The set will sort the values automatically
Console.WriteLine($"SortedSet: {string.Join(", ", sortedSet)}");
// SortedList<TKey, TValue> and SortedDictionary<TKey, TValue>
var sortedList = new SortedList<string, string>
{
    {
        "b",
        "valueB"
    },
    {
        "a",
        "valueA"
    }
};
Console.WriteLine($"SortedList: {string.Join(", ", sortedList)}");
var sortedDictionary = new SortedDictionary<string, string>
{
    {
        "b",
        "valueB"
    },
    {
        "a",
        "valueA"
    }
};
Console.WriteLine($"SortedDictionary: {string.Join(", ", sortedDictionary)}");