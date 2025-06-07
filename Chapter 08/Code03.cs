using System;
using System.IO;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "output.txt";
            string content = "Hello, World!";
            File.WriteAllText(filePath, content);
            Console.WriteLine("Text written to file.");
        }
    }
}