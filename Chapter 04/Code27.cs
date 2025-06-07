public void Display(string message)
{
    Console.WriteLine(message);
}

public void Display(string message, int times)
{
    for (int i = 0; i < times; i++)
    {
        Console.WriteLine(message);
    }
}