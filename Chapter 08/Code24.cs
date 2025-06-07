using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "somefile.txt";
        try
        {
            string text = File.ReadAllText(filePath);
            Console.WriteLine("File contents: ");
            Console.WriteLine(text);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"File not found: {e.Message}");
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine($"Access denied: {e.Message}");
        }
        catch (IOException e)
        {
            Console.WriteLine($"An I/O error occurred: {e.Message}");
        }
        finally
        {
            // This block will consistently execute, regardless of whether an exception was thrown or not.
            Console.WriteLine("Completed reading file.");
        }
    }
}