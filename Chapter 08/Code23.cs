using System;
using System.IO;

namespace PathBufferMemoryStreamExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Working with Paths
            string folder = @"C:\ExampleFolder";
            string fileName = "test.txt";
            string fullPath = Path.Combine(folder, fileName);
            Console.WriteLine($"Full Path: {fullPath}");
            // Create some data as a buffer
            byte[] buffer = new byte[1024]; // 1 KB buffer
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (byte)(i % 256);
            }

            // Working with Memory Stream
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Write the buffer to the memory stream
                memoryStream.Write(buffer, 0, buffer.Length);
                // Reset the position of the stream to the beginning
                memoryStream.Seek(0, SeekOrigin.Begin);
                // Read from the memory stream back into a new buffer
                byte[] readBuffer = new byte[1024];
                memoryStream.Read(readBuffer, 0, readBuffer.Length);
                // Verify that readBuffer is the same as buffer
                for (int i = 0; i < buffer.Length; i++)
                {
                    if (buffer[i] != readBuffer[i])
                    {
                        Console.WriteLine("Buffers are not equal!");
                        return;
                    }
                }

                Console.WriteLine("Buffers are equal!");
            }
        }
    }
}