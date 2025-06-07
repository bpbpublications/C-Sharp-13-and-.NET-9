using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (StreamWriter writer = new StreamWriter("example.txt", true))
        {
            writer.WriteLine("This line will be appended.");
        }
    }
}