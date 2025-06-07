using System;
using System.IO;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "output.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Hello, World!");
                writer.WriteLine("How are you?");
            }

            Console.WriteLine("Text written to file.");
        }
    }
}