public async Task LoadContent()
{
    string url = "https://example.com";
    string content = await GetWebsiteContentAsync(url);
    Console.WriteLine(content);
}