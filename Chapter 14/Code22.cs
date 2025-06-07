var httpClient = new HttpClient();
var url = "https://example.com/file.zip";
var localPath = "downloaded_file.zip";
try
{
    using var response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
    response.EnsureSuccessStatusCode();
    await using var streamToReadFrom = await response.Content.ReadAsStreamAsync();
    await using var streamToWriteTo = File.Open(localPath, FileMode.Create);
    await streamToReadFrom.CopyToAsync(streamToWriteTo);
    Console.WriteLine("File downloaded successfully.");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

