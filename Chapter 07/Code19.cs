using System.Net;

string originalUrlString = "This is a query with special chars like & and spaces!";
string escapedUrlString = WebUtility.UrlEncode(originalUrlString);
Console.WriteLine($"Escaped URL: {escapedUrlString}");
// URL Unescaping
string unescapedUrlString = WebUtility.UrlDecode(escapedUrlString);
Console.WriteLine($"Unescaped URL: {unescapedUrlString}");