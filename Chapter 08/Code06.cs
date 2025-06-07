using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (FileStream fs = new FileStream("example.txt", FileMode.Create))
        {
            string content = "Hello, World!";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(content);
            fs.Write(buffer, 0, buffer.Length);
        }
    }
}