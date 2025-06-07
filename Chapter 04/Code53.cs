public async Task<string> GetWebsiteContentAsync(string url)
{
    using (HttpClient client = new HttpClient())
    {
        string content = await client.GetStringAsync(url);
        return content;
    }
}