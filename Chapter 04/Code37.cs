using Xunit;
using System.Threading.Tasks;

public class FileProcessor
{
    public async Task<bool> ProcessFileAsync(string filePath)
    {
        // Simulate async file processing
        await Task.Delay(1000);
        return true;
    }
}

public class FileProcessorTests
{
    [Fact]
    public async Task ProcessFileAsync_ValidFilePath_ReturnsTrue()
    {
        FileProcessor fileProcessor = new FileProcessor();
        bool result = await fileProcessor.ProcessFileAsync("test.txt");
        Assert.True(result);
    }
}