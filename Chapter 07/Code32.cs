using System.Collections.Concurrent;

// ConcurrentDictionary<TKey, TValue>
var concurrentDictionary = new ConcurrentDictionary<string, string>();
concurrentDictionary.TryAdd("key1", "value1");
concurrentDictionary.TryAdd("key2", "value2");
Console.WriteLine($"ConcurrentDictionary: {string.Join(", ", concurrentDictionary)}");
// ConcurrentQueue<T>
var concurrentQueue = new ConcurrentQueue<int>();
concurrentQueue.Enqueue(1);
concurrentQueue.Enqueue(2);
concurrentQueue.TryDequeue(out int queueResult);
Console.WriteLine($"Dequeued from ConcurrentQueue: {queueResult}");
// ConcurrentStack<T>
var concurrentStack = new ConcurrentStack<int>();
concurrentStack.Push(3);
concurrentStack.Push(4);
concurrentStack.TryPop(out int stackResult);
Console.WriteLine($"Popped from ConcurrentStack: {stackResult}");
// ConcurrentBag<T>
var concurrentBag = new ConcurrentBag<int>();
concurrentBag.Add(5);
concurrentBag.Add(6);
concurrentBag.TryTake(out int bagResult);
Console.WriteLine($"Taken from ConcurrentBag: {bagResult}");
// BlockingCollection<T> can be a thread-safe buffer/collection.
// It wraps around an IProducerConsumerCollection<T> (like ConcurrentQueue by default)
var blockingCollection = new BlockingCollection<int>(5); // Bounded capacity of 5 items
blockingCollection.Add(7);
blockingCollection.Add(8);
Console.WriteLine($"BlockingCollection (after two additions): {string.Join(", ", blockingCollection)}");
// Let’s retrieve from the BlockingCollection
int blockingResult = blockingCollection.Take();
Console.WriteLine($"Taken from BlockingCollection: {blockingResult}");