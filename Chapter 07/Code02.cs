using System.Text;

string filePath = @"path_to_your_file.txt";
Encoding gb2312 = Encoding.GetEncoding("GB2312");
try
{
    using StreamReader reader = new StreamReader(filePath, gb2312);
    string content = reader.ReadToEnd();
    Console.WriteLine(content);
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}