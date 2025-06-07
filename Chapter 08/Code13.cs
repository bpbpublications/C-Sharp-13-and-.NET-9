using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string text = File.ReadAllText("nonexistent.txt");
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"File not found: {e.Message}");
        }
        catch (IOException e)
        {
            Console.WriteLine($"I/O error: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Unexpected error: {e.Message}");
        }
    }
}