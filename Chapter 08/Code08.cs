using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        using (FileStream fs = new FileStream("example.txt", FileMode.Open))
        {
            byte[] buffer = new byte[1024];
            int bytesRead = await fs.ReadAsync(buffer, 0, buffer.Length);
            Console.WriteLine($"Read {bytesRead} bytes.");
            string content = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Console.WriteLine(content);
        }
    }
}