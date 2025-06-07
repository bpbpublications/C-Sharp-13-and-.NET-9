var filePath = "C:\\MyFile.docx";
while (!CheckIsOpen(filePath))
{
    Thread.Sleep(1_000);
}

static bool CheckIsOpen(string file)
{
    try
    {
        var stream = new FileStream(file, FileMode.Open, FileAccess.Read);
        stream.Close();
        stream.Dispose();
        return true;
    }
    catch (FileNotFoundException f)
    {
        Console.WriteLine("File not found!");
        Console.ReadKey();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.Message);
        Console.ReadKey();
    }

    return false;
}