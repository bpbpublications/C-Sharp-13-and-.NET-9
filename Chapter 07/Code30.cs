using System.Collections;

// ArrayList
var arrayList = new ArrayList
{
    "apple",
    42,
    true
};
Console.WriteLine($"ArrayList: {string.Join(", ", arrayList.Cast<object>())}");
// Hashtable
var hashTable = new Hashtable
{
    {
        "key1",
        "value1"
    },
    {
        "key2",
        42
    }
};
Console.WriteLine($"Hashtable: key1={hashTable["key1"]}, key2={hashTable["key2"]}");
// Queue
var queue = new Queue();
queue.Enqueue("apple");
queue.Enqueue(42);
Console.WriteLine($"Queue (after two enqueues): {string.Join(", ", queue.Cast<object>())}");
var dequeuedValue = queue.Dequeue();
Console.WriteLine($"Dequeued from Queue: {dequeuedValue}");
// Stack
var stack = new Stack();
stack.Push("apple");
stack.Push(42);
Console.WriteLine($"Stack (after two pushes): {string.Join(", ", stack.Cast<object>())}");
var poppedValue = stack.Pop();
Console.WriteLine($"Popped from Stack: {poppedValue}");
// BitArray
var bitArray = new BitArray(new[] { true, false, true });
Console.Write("BitArray: ");
foreach (bool bit in bitArray)
{
    Console.Write(bit + " ");
}