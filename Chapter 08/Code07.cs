using (FileStream fs = new FileStream("example.txt", FileMode.Open))
{
    // Read from the beginning.
    byte[] buffer1 = new byte[5];
    fs.Read(buffer1, 0, buffer1.Length);
    // Seek to the beginning.
    fs.Seek(0, SeekOrigin.Begin);
    // Read again.
    byte[] buffer2 = new byte[5];
    fs.Read(buffer2, 0, buffer2.Length);
}