using System;
using System.IO;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "example.txt";
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine("File content is:");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
    }
}