foreach (int number in GetNumbers())
{
    Console.WriteLine(number);
}

Console.ReadKey();
IEnumerable<int> GetNumbers()
{
    Console.WriteLine("Code execution 1");
    yield return 1;
    Console.WriteLine("Code execution 2");
    yield return 2;
    Console.WriteLine("Code execution 3");
    yield return 3;
    Console.WriteLine("Code execution 3");
    yield return 4;
    Console.WriteLine("Code execution 4");
    yield return 5;
    Console.WriteLine("Code execution 5");
}