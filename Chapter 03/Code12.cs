var filePath = "C:\\temp\\file.txt";

tryAgain:
    try
    {
        var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        stream.Close();
        stream.Dispose();
    }
    catch
    {
        Thread.Sleep(1_000);
        goto tryAgain;
    }