using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (FileStream fs = new FileStream("example.txt", FileMode.Open))
        {
            byte[] buffer = new byte[1024];
            int bytesRead = fs.Read(buffer, 0, buffer.Length);
            Console.WriteLine($"Read {bytesRead} bytes.");
            // Convert bytes to string and display.
            string content = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Console.WriteLine(content);
        }
    }
}