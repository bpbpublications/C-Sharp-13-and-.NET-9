using System.Text;

string originalString = "Hello, World!";
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
Encoding win1252 = Encoding.GetEncoding("Windows-1252");
byte[] encodedBytes = win1252.GetBytes(originalString);
foreach (byte b in encodedBytes)
{
    Console.Write($"{b:x2} ");
}

Console.WriteLine();
string decodedString = win1252.GetString(encodedBytes);
Console.WriteLine(decodedString);