public void LoadContent()
{
    string url = "https://example.com";
    Task<string> contentTask = GetWebsiteContentAsync(url);
    string content = contentTask.GetAwaiter().GetResult();
    Console.WriteLine(content);
}