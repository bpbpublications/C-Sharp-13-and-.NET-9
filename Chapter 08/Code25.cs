string filePath = "somefile.txt";
if (File.Exists(filePath))
{
    string text = File.ReadAllText(filePath);
    Console.WriteLine("File contents: ");
    Console.WriteLine(text);
}
else
{
    Console.WriteLine("File does not exist.");
}