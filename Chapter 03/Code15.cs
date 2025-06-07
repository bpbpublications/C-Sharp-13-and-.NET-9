byte[] byteArray =
{
    0x43,
    0x23,
    0x4A,
    0x53,
    0x4D
};
string text = System.Text.Encoding.UTF8.GetString(byteArray);
var arrayFromText = System.Text.Encoding.Default.GetBytes(text);
string textFromArray = System.Text.Encoding.UTF8.GetString(arrayFromText);
string base64 = Convert.ToBase64String(byteArray);
var fromBase64 = Convert.FromBase64String(base64);
Console.WriteLine(text);
Console.WriteLine(base64);
if (text.Equals(textFromArray))
{
    Console.WriteLine("text equals to textFromArray");
}

if (arrayFromText.SequenceEqual(byteArray))
{
    Console.WriteLine("arrayFromText sequence equal to byteArray");
}

if (fromBase64.SequenceEqual(byteArray))
{
    Console.WriteLine("fromBase64 sequence equal to byteArray");
}

Console.ReadKey();