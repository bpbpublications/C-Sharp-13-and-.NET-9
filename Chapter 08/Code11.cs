using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("example.txt");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}