public void PrintNames(params string[] names)
{
    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
}

.. .
PrintNames("Alice", "Bob", "Charlie"); // Outputs: Alice, Bob, Charlie
