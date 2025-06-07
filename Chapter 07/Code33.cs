using System.Collections.Immutable;

// ImmutableArray<T>
ImmutableArray<int> immutableArray = ImmutableArray.Create(1, 2, 3, 4);
Console.WriteLine($"ImmutableArray: {string.Join(", ", immutableArray)}");
// ImmutableList<T>
ImmutableList<int> immutableList = ImmutableList.Create(5, 6, 7, 8);
Console.WriteLine($"ImmutableList: {string.Join(", ", immutableList)}");
// ImmutableDictionary<TKey, TValue>
var builder = ImmutableDictionary.CreateBuilder<string, string>();
builder.Add("key1", "value1");
builder.Add("key2", "value2");
ImmutableDictionary<string, string> immutableDictionary = builder.ToImmutable();
Console.WriteLine($"ImmutableDictionary: {string.Join(", ", immutableDictionary)}");
// ImmutableHashSet<T>
ImmutableHashSet<int> immutableHashSet = ImmutableHashSet.Create(9, 10, 11);
Console.WriteLine($"ImmutableHashSet: {string.Join(", ", immutableHashSet)}");
// ImmutableQueue<T>
ImmutableQueue<int> immutableQueue = ImmutableQueue.Create(12, 13, 14);
immutableQueue = immutableQueue.Enqueue(15); // Since it’s immutable, to add, we get a new queue back
Console.WriteLine($"ImmutableQueue (after Enqueue): {string.Join(", ", immutableQueue)}");
var dequeuedValue = immutableQueue.Dequeue();
Console.WriteLine($"Dequeued value from ImmutableQueue: {dequeuedValue.Peek()}, is empty: {dequeuedValue.IsEmpty}");
// ImmutableStack<T>
ImmutableStack<int> immutableStack = ImmutableStack.Create(16, 17, 18);
immutableStack = immutableStack.Push(19); // Since it’s immutable, to push, we get a new stack back
Console.WriteLine($"ImmutableStack (after Push): {string.Join(", ", immutableStack)}");
var poppedValue = immutableStack.Pop();
Console.WriteLine($"Popped value from ImmutableStack: {poppedValue.Peek()}, is empty: {poppedValue.IsEmpty}");