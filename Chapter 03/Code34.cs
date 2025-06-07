try
{
    // Open a file to read
    using FileStream fileStream = File.Open("C:\\myFile.txt", FileMode.Open, FileAccess.Read);
    // Read file contents
    byte[] buffer = new byte[1024];
    fileStream.Read(buffer, 0, buffer.Length);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"File not found: {ex.Message}");
}
catch (IOException ex)
{
    Console.WriteLine($"An I/O error occurred: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
}
finally
{
// Clean up resources or perform necessary
// actions
}