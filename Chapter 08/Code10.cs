using System;
using System.IO;

class Program
{
    static void Main()
    {
        string text = File.ReadAllText("example.txt");
        Console.WriteLine(text);
    }
}